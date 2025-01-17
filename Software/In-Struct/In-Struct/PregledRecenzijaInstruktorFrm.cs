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
    public partial class PregledRecenzijaInstruktorFrm : HelperFrm
    {
        Korisnik instruktor = Autentikacija.VratiImeKorisnika();
        public PregledRecenzijaInstruktorFrm()
        {
            InitializeComponent();
            postaviHelp("RecenzijeInstruktor.htm");
        }
        private void PregledRecenzijaInstruktorFrm_Load(object sender, EventArgs e)
        {
            popuniRecenzije();
            dgvRecenzije.Columns["recenzija_id"].Visible = false;
            dgvRecenzije.Columns["korisnik1"].Visible = false;
            dgvRecenzije.Columns["ucenik_ID"].Visible = false;
            dgvRecenzije.Columns["instruktor_ID"].Visible = false;
            dgvRecenzije.Columns["Tip_recenzije_ID"].Visible = false;
            dgvRecenzije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecenzije.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //dgvRecenzije.Columns[3].HeaderText = "Korisničko ime";
            //dgvRecenzije.Columns[4].HeaderText = "Tip recenzije";
            dgvRecenzije.Columns["Korisnik"].HeaderText = "Korisničko ime";
            dgvRecenzije.Columns["Tip_recenzije"].HeaderText = "Tip recenzije";
        }

        private void popuniRecenzije()
        {
            using (var kontekst = new PI2301_DBEntities())
            {
                var query = from p in kontekst.Recenzijas.Include("Korisnik").Include("Tip_recenzije")
                            where p.instruktor_ID == instruktor.korisnik_ID
                            select p;
                dgvRecenzije.DataSource = query.ToList();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetnaInstruktor pocetna = new PocetnaInstruktor();
            pocetna.ShowDialog();
        }
    }
}
