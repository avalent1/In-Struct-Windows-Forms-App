using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class OtkazivanjeTerminaFrm : Form
    {
        public OtkazivanjeTerminaFrm(Korisnik korisnik)
        {
            InitializeComponent();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OtkazivanjeTerminaFrm_Load(object sender, EventArgs e)
        {
            dgvTermini.DataSource = popuniDgv();
            dgvTermini.Columns["pripada_ID"].Visible = false;
        }

        private object popuniDgv()
        {
            using (var context = new PI2301_DBEntities())
            {
                int trenutniKor = Autentikacija.VratiIDKorisnika();
                DateTime currentDate = DateTime.Now;
                var query = from pr in context.pripadas
                            join termin in context.Termins on pr.termin_ID equals termin.termin_ID
                            join instrukcija in context.Instrukcijas on termin.instrukcija_ID equals instrukcija.instrukcija_ID
                            join kor in context.Korisniks on pr.korisnik_ID equals kor.korisnik_ID
                            join korisnik in context.Korisniks on instrukcija.Korisnik.korisnik_ID equals korisnik.korisnik_ID
                            where termin.vrijeme > currentDate && pr.korisnik_ID == trenutniKor
                            select new
                            {
                                instrukcija.predmet,
                                instrukcija.cijena,
                                instrukcija.trajanje,
                                instrukcija.mjesto,
                                termin.vrijeme,
                                korisnik.ime,
                                korisnik.prezime,
                                pr.pripada_ID
                            };
                return query.ToList();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2301_DBEntities())
            {
                int pripID = int.Parse(dgvTermini.CurrentRow.Cells["pripada_ID"].Value.ToString());

                var query = from pr in context.pripadas
                            where pr.pripada_ID == pripID
                            select pr;

                var res = query.ToList();

                context.pripadas.Remove(res[0] as pripada);
                context.SaveChanges();
            }
            MessageBox.Show("Termin uspješno otkazan!");
            Close();
        }
    }
}
