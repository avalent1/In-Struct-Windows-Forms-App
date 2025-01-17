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
    public partial class DetaljiInstrukcijeFrm : HelperFrm
    {
        Instrukcija odabranaInstrukcija;
        public DetaljiInstrukcijeFrm(Instrukcija instrukcija)
        {
            InitializeComponent();
            odabranaInstrukcija = instrukcija;
            postaviHelp("DetaljiInstrukcije.htm");
        }

        private void DetaljiInstrukcijeFrm_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = odabranaInstrukcija.predmet;
            lblCijena.Text = odabranaInstrukcija.cijena.ToString();
            lblTrajanje.Text = odabranaInstrukcija.trajanje.ToString();
            lblAdresa.Text = odabranaInstrukcija.adresa;
            lblMjesto.Text = odabranaInstrukcija.mjesto;
            Korisnik instruktor;
            using (var context = new PI2301_DBEntities())
            {
                context.Instrukcijas.Attach(odabranaInstrukcija);
                instruktor = odabranaInstrukcija.Korisnik;
            }
            lblIme.Text = instruktor.ime;
            lblPrezime.Text = instruktor.prezime;
            lblEmail.Text = instruktor.email;
            lblTelefon.Text = instruktor.telefon;
        }

        private void btnOdaberiTermin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string instr = lblIme.Text + ' ' + lblPrezime.Text;
            ZakazivanjeTerminaInstrukcijaFrm zakazivanjeTerminaInstrukcijaFrm = new ZakazivanjeTerminaInstrukcijaFrm(odabranaInstrukcija, instr);
            zakazivanjeTerminaInstrukcijaFrm.ShowDialog();
            this.Show();
        }

        private void btnRecenzijeInstruktora_Click(object sender, EventArgs e)
        {
            Korisnik instruktor;
            using (var context = new PI2301_DBEntities())
            {
                context.Instrukcijas.Attach(odabranaInstrukcija);
                instruktor = odabranaInstrukcija.Korisnik;
            }
            this.Hide();
            PregledRecenzijaFrm pregledRecenzijaFrm = new PregledRecenzijaFrm(odabranaInstrukcija);
            pregledRecenzijaFrm.ShowDialog();
            this.Show();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
