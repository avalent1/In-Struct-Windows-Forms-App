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
    public partial class PregledRecenzijaFrm : HelperFrm
    {
        public Instrukcija odabrana;
        public PregledRecenzijaFrm(Instrukcija instrukcija)
        {
            InitializeComponent();
            postaviHelp("pregledRecenzija.htm");
            odabrana = instrukcija;
        }

        private void PregledRecenzijaFrm_Load(object sender, EventArgs e)
        {
            popuniCmb();
            popuniInstruktore();
            popuniRecenzije();
            dgvInstruktori.Columns["korisnik_ID"].Visible = false;
            dgvInstruktori.Columns["lozinka"].Visible = false;
            dgvInstruktori.Columns["uloga_ID"].Visible = false;
            dgvInstruktori.Columns["instrukcijas"].Visible = false;
            dgvInstruktori.Columns["Racuns"].Visible = false;
            dgvInstruktori.Columns["Recenzijas"].Visible = false;
            dgvInstruktori.Columns["Racuns1"].Visible = false;
            dgvInstruktori.Columns["Recenzijas1"].Visible = false;
            dgvInstruktori.Columns["pripadas"].Visible = false;
            dgvInstruktori.Columns["Uloga_ID"].Visible = false;
            dgvInstruktori.Columns["Uloga"].Visible = false;
            dgvInstruktori.Columns["korisnicko_ime"].Visible = false;
            dgvInstruktori.Columns["ime"].HeaderText = "Ime";
            dgvInstruktori.Columns["prezime"].HeaderText = "Prezime";
            dgvInstruktori.Columns["email"].HeaderText = "Email";
            dgvInstruktori.Columns["telefon"].HeaderText = "Telefon";

            dgvRecenzije.Columns["ucenik_ID"].Visible = false;
            dgvRecenzije.Columns["recenzija_ID"].Visible = false;
            dgvRecenzije.Columns["instruktor_ID"].Visible = false;
            dgvRecenzije.Columns["Tip_recenzije_ID"].Visible = false;
            dgvRecenzije.Columns["Korisnik"].Visible = false;
            dgvRecenzije.Columns["Korisnik1"].Visible = false;
            dgvRecenzije.Columns["Tip_recenzije"].HeaderText = "Tip recenzije";
        }

        private void popuniCmb()
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Instrukcijas.Select(x => x.predmet).Distinct()
                            select p;
                cmbPredmeti.DataSource = query.ToList();
            }
        }

        private void popuniInstruktore()
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Korisniks 
                            join o in kontekst.Instrukcijas on p.korisnik_ID equals o.instruktor_ID
                            where o.predmet == odabrana.predmet && o.instrukcija_ID == odabrana.instrukcija_ID
                            select p;
                dgvInstruktori.DataSource = query.ToList();
            }
        }
        private void popuniInstruktorePoPredmetu()
        {
            string predmet = vratiPredmet();
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = (from p in kontekst.Korisniks
                             join o in kontekst.Instrukcijas on p.korisnik_ID equals o.instruktor_ID
                             where o.predmet == predmet && p.uloga_ID == 2
                             select p).Distinct();
                dgvInstruktori.DataSource = query.ToList();
            }
        }

        private string vratiPredmet()
        {
            return cmbPredmeti.SelectedItem as string;
        }

        private Korisnik vratiTrenutnogInstruktora()
        {
            return dgvInstruktori.CurrentRow.DataBoundItem as Korisnik;
        }

        private void popuniRecenzije()
        {
            Korisnik trenutni = vratiTrenutnogInstruktora();
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Recenzijas.Include("Tip_recenzije")
                            where p.instruktor_ID == trenutni.korisnik_ID
                            select p;
                dgvRecenzije.DataSource = query.ToList();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInstruktori_SelectionChanged(object sender, EventArgs e)
        {
            popuniRecenzije();
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniInstruktorePoPredmetu();
        }
    }
}
