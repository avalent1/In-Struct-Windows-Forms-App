using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class PocetnaUcenik : HelperFrm
    {
        Korisnik prijavljeniUcenik;
        List<Instrukcija> ins;
        public PocetnaUcenik(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniUcenik = korisnik;
            postaviHelp("PregledInstrukcija.htm");
        }

        private void PopisInstrukcijaUcenik_Load(object sender, EventArgs e)
        {
            OsvjeziDataGrid();
            PopuniKriterij();
            lblIme.Text = prijavljeniUcenik.ime;
            lblPrezime.Text = prijavljeniUcenik.prezime;
            dgvPopisInstrukcija.Columns["predmet"].HeaderText = "Predmet";
            dgvPopisInstrukcija.Columns["cijena"].HeaderText = "Cijena";
            dgvPopisInstrukcija.Columns["trajanje"].HeaderText = "Trajanje";
            dgvPopisInstrukcija.Columns["mjesto"].HeaderText = "Mjesto";
        }
        private void PopuniKriterij()
        {
            cmbKriterij.Items.Add("Predmet");
            cmbKriterij.Items.Add("Cijena");
            cmbKriterij.Items.Add("Trajanje");
            cmbKriterij.Items.Add("Mjesto");
        }

        private void PopuniPodatak(string odabraniKriterij)
        {
            List<string> vrijednosti;
            switch (odabraniKriterij)
            {
                case "Predmet":
                    vrijednosti = ins.Select(e => e.predmet).Distinct().ToList();
                    break;
                case "Cijena":
                    vrijednosti = ins.Select(e => e.cijena.ToString()).Distinct().ToList();
                    break;
                case "Trajanje":
                    vrijednosti = ins.Select(e => e.trajanje.ToString()).Distinct().ToList();
                    break;
                case "Mjesto":
                    vrijednosti = ins.Select(e => e.mjesto).Distinct().ToList();
                    break;
                default:
                    vrijednosti = new List<string>();
                    break;
            }

            cmbPodatak.DataSource = vrijednosti;
        }
        private void OsvjeziDataGrid()
        {
            using (var context = new PI2301_DBEntities())
            {
                DateTime vrijeme = DateTime.Now;

                var instrukcije = (
                    from instrukcija in context.Instrukcijas
                    where instrukcija.Termins.Any(termin => termin.vrijeme > vrijeme)
                    select instrukcija
                );
                ins = instrukcije.ToList();
                dgvPopisInstrukcija.DataSource = ins;
                dgvPopisInstrukcija.Columns["instrukcija_ID"].Visible = false;
                dgvPopisInstrukcija.Columns["instruktor_ID"].Visible = false;
                dgvPopisInstrukcija.Columns["adresa"].Visible = false;
                dgvPopisInstrukcija.Columns["Korisnik"].Visible = false;
                dgvPopisInstrukcija.Columns["Racuns"].Visible = false;
                dgvPopisInstrukcija.Columns["Termins"].Visible = false;
            }

            dgvPopisInstrukcija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPopisInstrukcija.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void cmbKriterij_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabraniKriterij = cmbKriterij.SelectedItem.ToString();
            PopuniPodatak(odabraniKriterij);
        }

        private void cmbPodatak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabraniPodatak = cmbPodatak.SelectedItem.ToString();
            Filtriraj(odabraniPodatak);
        }

        private void Filtriraj(string odabraniPodatak)
        {
            string odabraniKriterij = cmbKriterij.SelectedItem.ToString();
            List<Instrukcija> filtriraneInstrukcije;

            switch (odabraniKriterij)
            {
                case "Predmet":
                    filtriraneInstrukcije = ins.Where(e => e.predmet == odabraniPodatak).ToList();
                    break;
                case "Cijena":
                    int podatak = int.Parse(odabraniPodatak);
                    filtriraneInstrukcije = ins.Where(e => e.cijena == podatak).ToList();
                    break;
                case "Trajanje":
                    int podatak2 = int.Parse(odabraniPodatak);
                    filtriraneInstrukcije = ins.Where(e => e.trajanje == podatak2).ToList();
                    break;
                case "Mjesto":
                    filtriraneInstrukcije = ins.Where(e => e.mjesto == odabraniPodatak).ToList();
                    break;
                default:
                    filtriraneInstrukcije = new List<Instrukcija>();
                    break;
            }

            dgvPopisInstrukcija.DataSource = filtriraneInstrukcije;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Instrukcija odabranaInstrukcija = dgvPopisInstrukcija.CurrentRow.DataBoundItem as Instrukcija;
            this.Hide();
            DetaljiInstrukcijeFrm forma = new DetaljiInstrukcijeFrm(odabranaInstrukcija);
            forma.ShowDialog();
            this.Show();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OsvjeziDataGrid();
        }

        private void btnOdjavi_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnPopisPohadanih_Click(object sender, EventArgs e)
        {
            this.Hide();
            PregledInstrukcijaUcenik pregledInstrukcijaUcenik = new PregledInstrukcijaUcenik();
            pregledInstrukcijaUcenik.ShowDialog();
            this.Show();
        }

        private void btnOtkazivanje_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtkazivanjeTerminaFrm otkazivanjeTerminaFrm = new OtkazivanjeTerminaFrm(prijavljeniUcenik);
            otkazivanjeTerminaFrm.ShowDialog();
            this.Show();
        }

        private void PocetnaUcenik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autentikacija.ObrisiKorisnika();
        }
    }
}
