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
    public partial class PocetnaInstruktor : HelperFrm
    {
        FormCollection openForms = Application.OpenForms;
        Korisnik korisnikInstruktor = Autentikacija.VratiImeKorisnika();
        DateTime trazeniDatum;
        public PocetnaInstruktor()
        {
            InitializeComponent();
            postaviHelp("PocetnaInstruktor.htm");
        }

        private void PocetnaInstruktor_Load(object sender, EventArgs e)
        {
            osvjeziInstrukcije();
            osvjetiTermine();
            lblIme.Text = korisnikInstruktor.ime;
            lblPrezime.Text = korisnikInstruktor.prezime;
        }

        private void osvjetiTermine()
        {
            Instrukcija trenutna = DohvatiTrenutnuInstrukciju();
            if (trenutna != null)
            {
                DohvatiTerminePoInstrukciji(trenutna);
                dgvTermini.Columns["instrukcija_ID"].Visible = false;
                dgvTermini.Columns["Instrukcija"].Visible = false;
                dgvTermini.Columns["Racuns"].Visible = false;
                dgvTermini.Columns["pripadas"].Visible = false;
                dgvTermini.Columns["termin_id"].Visible = false; 
                dgvTermini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTermini.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvTermini.Columns[1].HeaderText = "Broj mjesta";
            }
        }

        private void osvjeziInstrukcije()
        {
            dgvZakazaneInstrukcije.DataSource = null;
            DohvatiInstrukcije(korisnikInstruktor);
            dgvZakazaneInstrukcije.Columns["Termins"].Visible = false;
            dgvZakazaneInstrukcije.Columns["Racuns"].Visible = false;
            dgvZakazaneInstrukcije.Columns["Korisnik"].Visible = false;
            dgvZakazaneInstrukcije.Columns["instruktor_id"].Visible = false;
            dgvZakazaneInstrukcije.Columns["instrukcija_id"].Visible = false;
        }

        private void DohvatiInstrukcije(Korisnik korisnik)
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Instrukcijas.Include("Racuns").Include("Termins").Include("Korisnik")
                            where p.instruktor_ID == korisnik.korisnik_ID
                            select p;
                dgvZakazaneInstrukcije.DataSource = query.ToList();
            }
            if (dgvZakazaneInstrukcije == null)
            {
                dgvZakazaneInstrukcije.DataSource = null;
                dgvTermini.DataSource = null;
            }
        }

        private void DohvatiTerminePoInstrukciji(Instrukcija instrukcija)
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Termins
                            where p.instrukcija_ID == instrukcija.instrukcija_ID 
                            && p.vrijeme >= DateTime.Now
                            select p;
                dgvTermini.DataSource = query.ToList();
            }
        }

        private Instrukcija DohvatiTrenutnuInstrukciju()
        {
            if (dgvZakazaneInstrukcije.CurrentRow == null) return null;
            return dgvZakazaneInstrukcije.CurrentRow.DataBoundItem as Instrukcija;

        }

        private void DohvatiTerminPoVremenu(DateTime datum, Instrukcija instrukcija)
        {
            dgvTermini.DataSource = null;
            int datum1 = datum.Day;
            int datum2 = datum.Month;
            int datum3 = datum.Year;
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Termins
                            where p.vrijeme.Day == datum1 && p.vrijeme.Month == datum2 && p.vrijeme.Year == datum3 && p.instrukcija_ID == instrukcija.instrukcija_ID
                            select p;
                dgvTermini.DataSource = query.ToList();
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            foreach (Form form in openForms)
            {
                if (form.Name == "PocetnaFrm")
                {
                    continue;
                }

                if (form.Visible == false)
                {
                    form.Close();
                }
            }
            Dispose();
            
        }



        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            trazeniDatum = odabraniDatum.Value;
            DohvatiTerminPoVremenu(trazeniDatum, DohvatiTrenutnuInstrukciju());
            dgvTermini.Columns["instrukcija_ID"].Visible = false;
            dgvTermini.Columns["Instrukcija"].Visible = false;
            dgvTermini.Columns["Racuns"].Visible = false;
            dgvTermini.Columns["pripadas"].Visible = false;
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            this.Hide();
            IzdavanjeRacunaFrm izdavanjeRacunaFrm = new IzdavanjeRacunaFrm(korisnikInstruktor);
            izdavanjeRacunaFrm.ShowDialog();
            this.Show();
        }
        private void dgvZakazaneInstrukcije_SelectionChanged(object sender, EventArgs e)
        {
            osvjetiTermine();
        }

        private void btnKreirajOglas_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreiranjeOglasaFrm kreiranjeOglasa = new KreiranjeOglasaFrm();
            kreiranjeOglasa.ShowDialog();
            this.Show();
            osvjeziInstrukcije();
            osvjetiTermine();
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            osvjeziInstrukcije();
            osvjetiTermine();
        }

        private void btnKalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            KalendarskiPrikazFrm kalendar = new KalendarskiPrikazFrm();
            kalendar.ShowDialog();
            this.Show();
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            PregledRecenzijaInstruktorFrm recenzije = new PregledRecenzijaInstruktorFrm();
            this.Hide();
            recenzije.ShowDialog();
            this.Show();
        }

        private void btnPregledOdradenih_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledOdradenihFrm popisInstrukcija = new PregledOdradenihFrm();
            popisInstrukcija.ShowDialog();
            this.Show();
        }

        private void PocetnaInstruktor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autentikacija.ObrisiKorisnika();
        }

    }
}
