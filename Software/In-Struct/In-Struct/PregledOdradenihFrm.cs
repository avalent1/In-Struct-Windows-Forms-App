using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class PregledOdradenihFrm : HelperFrm
    {
        Korisnik instruktor = Autentikacija.VratiImeKorisnika();
        public PregledOdradenihFrm()
        {
            InitializeComponent();
            postaviHelp("PregledOdradenih.htm");
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Hide();
            PocetnaInstruktor pocetna = new PocetnaInstruktor();
            pocetna.ShowDialog();
        }

        private void popuniInstrukcije()
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Instrukcijas
                            join o in kontekst.Termins on p.instrukcija_ID equals o.instrukcija_ID
                            where p.instruktor_ID == instruktor.korisnik_ID
                            && o.vrijeme < DateTime.Now
                            select p;
                dgvPopisOdradenih.DataSource = query.ToList();
            }
        }

        private void PregledOdradenihFrm_Load(object sender, EventArgs e)
        {
            popuniInstrukcije();
            dgvPopisOdradenih.Columns["Racuns"].Visible = false;
            dgvPopisOdradenih.Columns["instruktor_ID"].Visible = false;
            dgvPopisOdradenih.Columns["Termins"].Visible = false;
            dgvPopisOdradenih.Columns["Korisnik"].Visible = false;
            dgvPopisOdradenih.Columns["instrukcija_ID"].Visible = false;
        }

        private void PregledOdradenihFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
