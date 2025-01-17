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
    public partial class DodavanjeRecenzijeFrm : Form
    {
        Korisnik korisnik;
        public string term;
        public DodavanjeRecenzijeFrm(Korisnik kor, string termin)
        {
            InitializeComponent();
            korisnik = kor;
            term = termin;
        }

        private void DodavanjeRecenzijeFrm_Load(object sender, EventArgs e)
        {
            ImeLabel.Text = korisnik.ime;
            PrezimeLabel.Text = korisnik.prezime;
            txtTermin.Text = term;
            popuniKriterij();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2301_DBEntities())
            {
                int idInst = korisnik.korisnik_ID;
                int idKor = Autentikacija.VratiIDKorisnika();
                int ocjena = int.Parse(txtOcjena.Text);
                string komentar = txtKomentar.Text;
                int idRecenz = cmbKriterij.SelectedIndex+1;

                Recenzija novaRecenzija = new Recenzija
                {
                    Ocjena = ocjena,
                    Komentar = komentar,
                    ucenik_ID = idKor,
                    instruktor_ID = idInst,
                    Tip_recenzije_ID = idRecenz
                };

                context.Recenzijas.Add(novaRecenzija);
                context.SaveChanges();

            }
            MessageBox.Show("Recenzija uspješno dodana!");
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void popuniKriterij()
        {

            List<Tip_recenzije> tipovi;

            using(var context = new PI2301_DBEntities())
            {
                tipovi = context.Tip_recenzije.ToList();
            }

            cmbKriterij.DataSource = tipovi;

        }

    }
}
