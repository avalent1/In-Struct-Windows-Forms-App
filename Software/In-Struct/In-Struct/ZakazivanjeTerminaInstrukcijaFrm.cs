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
    public partial class ZakazivanjeTerminaInstrukcijaFrm : Form
    {

        public Instrukcija odabranaInstrukcija;
        public string instruktor;
        public List<Termin> termins;
        public int odabraniTerminID;

        public ZakazivanjeTerminaInstrukcijaFrm(Instrukcija instrukcija, string instr)
        {
            InitializeComponent();
            odabranaInstrukcija = instrukcija;
            instruktor = instr;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            using (var context = new PI2301_DBEntities())
            {
                int idKor = Autentikacija.VratiIDKorisnika();
                int idTermin = odabraniTerminID;
                bool racunIzdan = false;

                pripada noviZakazani = new pripada
                {
                    termin_ID = idTermin,
                    korisnik_ID = idKor,
                    racunIzdan = racunIzdan
                };

                context.pripadas.Add(noviZakazani);
                context.SaveChanges();
            }
            MessageBox.Show("Termin uspješno zakazan!");
            Close();
        }

        private void ZakazivanjeTerminaInstrukcijaFrm_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = odabranaInstrukcija.predmet.ToString();
            lblInstruktor.Text = instruktor.ToString();
            lblTrajanje.Text = odabranaInstrukcija.trajanje.ToString();
            lblMjesto.Text = odabranaInstrukcija.mjesto.ToString();
            lblAdresa.Text = odabranaInstrukcija.adresa.ToString();
            popuniVrijeme();
            if (Autentikacija.VratiIDKorisnika() == 0)
            {
                btnZakazi.Enabled = false;
            }
        }

        private void popuniVrijeme()
        {
            List<DateTime> termini = new List<DateTime>();

            using (var context = new PI2301_DBEntities())
            {
                var query = from p in context.Termins
                            where p.instrukcija_ID == odabranaInstrukcija.instrukcija_ID
                            && p.vrijeme > DateTime.Now
                            select p;
                termins = query.ToList();

                foreach (Termin termin in termins)
                {
                    termini.Add(termin.vrijeme);
                }

            }
            cmbVrijeme.DataSource = termini;
        }

        private void cmbVrijeme_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(Termin t in termins)
            {
                if(t.vrijeme.ToString() == cmbVrijeme.SelectedValue.ToString())
                {
                    odabraniTerminID = t.termin_ID;
                }
            }
        }
    }
}
