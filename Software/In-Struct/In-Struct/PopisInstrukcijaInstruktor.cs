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
    public partial class PopisInstrukcijaInstruktor : Form
    {
        Korisnik logiraniInstruktor = Autentikacija.VratiImeKorisnika();
        public PopisInstrukcijaInstruktor()
        {
            InitializeComponent();
        }

        private void PopisInstrukcijaInstruktor_Load(object sender, EventArgs e)
        {
            OsvjeziDataGrid();
            PopuniKriterij();
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
            switch (odabraniKriterij)
            {
                case "Predmet":
                    using (var context = new PI2301_DBEntities())
                    {
                        var vrijednosti = context.Instrukcijas.Select(e => e.predmet).Distinct().ToList();
                        cmbPodatak.DataSource = vrijednosti;
                    }
                    break;
                case "Cijena":
                    using (var context = new PI2301_DBEntities())
                    {
                        var vrijednosti = context.Instrukcijas.Select(e => e.cijena).Distinct().ToList();
                        cmbPodatak.DataSource = vrijednosti;
                    }
                    break;
                case "Trajanje":
                    using (var context = new PI2301_DBEntities())
                    {
                        var vrijednosti = context.Instrukcijas.Select(e => e.trajanje).Distinct().ToList();
                        cmbPodatak.DataSource = vrijednosti;
                    }
                    break;
                case "Mjesto":
                    using (var context = new PI2301_DBEntities())
                    {
                        var vrijednosti = context.Instrukcijas.Select(e => e.mjesto).Distinct().ToList();
                        cmbPodatak.DataSource = vrijednosti;
                    }
                    break;
                default:
                    break;
            }
        }
        private void OsvjeziDataGrid()
        {
            using (var context = new PI2301_DBEntities())
            {
                dgvPopisInstrukcija.DataSource = context.Instrukcijas.ToList();
                dgvPopisInstrukcija.Columns["instrukcija_ID"].Visible = false;
                dgvPopisInstrukcija.Columns["instruktor_ID"].Visible = false;
                dgvPopisInstrukcija.Columns["adresa"].Visible = false;
                dgvPopisInstrukcija.Columns["Korisnik"].Visible = false;
                dgvPopisInstrukcija.Columns["Racuns"].Visible = false;
                dgvPopisInstrukcija.Columns["Termins"].Visible = false;
            }
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
            switch (odabraniKriterij)
            {
                case "Predmet":
                    using (var context = new PI2301_DBEntities())
                    {
                        var filtriraneInstrukcije = context.Instrukcijas.Where(e => e.predmet == odabraniPodatak).ToList();
                        dgvPopisInstrukcija.DataSource = filtriraneInstrukcije;
                    }
                    break;
                case "Cijena":
                    using (var context = new PI2301_DBEntities())
                    {
                        int podatak = int.Parse(odabraniPodatak);
                        var filtriraneInstrukcije = context.Instrukcijas.Where(e => e.cijena == podatak).ToList();
                        dgvPopisInstrukcija.DataSource = filtriraneInstrukcije;
                    }
                    break;
                case "Trajanje":
                    using (var context = new PI2301_DBEntities())
                    {
                        int podatak = int.Parse(odabraniPodatak);
                        var filtriraneInstrukcije = context.Instrukcijas.Where(e => e.trajanje == podatak).ToList();
                        dgvPopisInstrukcija.DataSource = filtriraneInstrukcije;
                    }
                    break;
                case "Mjesto":
                    using (var context = new PI2301_DBEntities())
                    {
                        var filtriraneInstrukcije = context.Instrukcijas.Where(e => e.mjesto == odabraniPodatak).ToList();
                        dgvPopisInstrukcija.DataSource = filtriraneInstrukcije;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Instrukcija odabranaInstrukcija = dgvPopisInstrukcija.CurrentRow.DataBoundItem as Instrukcija;
            DetaljiInstrukcijeFrm forma = new DetaljiInstrukcijeFrm(odabranaInstrukcija);
            forma.ShowDialog();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OsvjeziDataGrid();
        }

        private void btnOdjavi_Click(object sender, EventArgs e)
        {
            PocetnaInstruktor forma = new PocetnaInstruktor();
            this.Hide();
            forma.ShowDialog();
        }
    }
}
