using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class KreiranjeOglasaFrm : HelperFrm
    {
        Korisnik korisnik = Autentikacija.VratiImeKorisnika();
        Instrukcija instrukcija1;
        public KreiranjeOglasaFrm()
        {
            InitializeComponent();
            postaviHelp("KreiranjeOglasa.htm");
        }
        private void KreiranjeOglasaFrm_Load(object sender, EventArgs e)
        {
        }

        private void Osvjezi()
        {
            TerminiDgv.DataSource = null;
            DohvatiTermine(instrukcija1);
            TerminiDgv.Columns["Instrukcija"].Visible = false;
            TerminiDgv.Columns["Racuns"].Visible = false;
            TerminiDgv.Columns["pripadas"].Visible = false;
            TerminiDgv.Columns["instrukcija_id"].Visible = false;
            TerminiDgv.Columns["termin_id"].Visible = false;
        }

        private void DohvatiTermine(Instrukcija instrukcija)
        {
            using (var item = new PI2301_DBEntities())
            {
                var query = from p in item.Termins
                            join o in item.Instrukcijas on p.instrukcija_ID equals o.instrukcija_ID
                            where p.instrukcija_ID == instrukcija.instrukcija_ID
                            select p;
                TerminiDgv.DataSource = query.ToList();
            }
        }

        private void OdustaniBtn_Click(object sender, EventArgs e)
        {
            Hide();
            PocetnaInstruktor pocetna = new PocetnaInstruktor();
            pocetna.ShowDialog(); 
        }

        private void DodajInstrukcijuBtn_Click(object sender, EventArgs e)
        {
            UpitOglas forma = new UpitOglas();
            forma.ShowDialog();
            if (UpitOglas.moze == true)
            {
                string predmet = PredmetTxtBox.Text;
                string cijena = CijenaTxtBox.Text;
                string trajanje = TrajanjeTxtBox.Text;
                string mjesto = MjestoTxtBox.Text;
                string adresa = AdresaTxtBox.Text;

                using (var item = new PI2301_DBEntities())
                {
                    //var query = (from p in item.Korisniks where p.korisnik_ID == korisnik.korisnik_ID select new { p }).Single();
                    //Korisnik korisnik2 = query.p;
                    item.Korisniks.Attach(korisnik);
                    Instrukcija instrukcija = new Instrukcija()
                    {
                        predmet = predmet,
                        Korisnik = korisnik,
                        cijena = int.Parse(cijena),
                        trajanje = int.Parse(trajanje),
                        mjesto = mjesto,
                        adresa = adresa
                    };
                    instrukcija1 = instrukcija;
                    instrukcija.Korisnik = korisnik;
                    item.Instrukcijas.Add(instrukcija);
                    item.SaveChanges();
                    DodajTerminBtn.Enabled = true;
                }
                OdustaniBtn.Enabled = false;
                Osvjezi();
            }
        }

        private void DodajTerminBtn_Click(object sender, EventArgs e)
        {
            DodavanjeTerminaFrm forma = new DodavanjeTerminaFrm(instrukcija1);
            forma.ShowDialog();
            Osvjezi();
            if (TerminiDgv.RowCount > 0)
            {
                KreirajOglasButton.Enabled = true;
            }
        }

        private void KreirajOglasButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
