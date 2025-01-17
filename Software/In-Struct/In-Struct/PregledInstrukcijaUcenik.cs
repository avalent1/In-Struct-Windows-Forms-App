using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class PregledInstrukcijaUcenik : HelperFrm
    {
        Korisnik korisnik = Autentikacija.VratiImeKorisnika();
        public PregledInstrukcijaUcenik()
        {
            InitializeComponent();
            postaviHelp("PregledOdrađenihInstrukcija.htm");
        }

        private void ZatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PregledInstrukcijaUcenik_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            PopisOdradenihInstrukcijaDgv.DataSource = null;
            PopisOdradenihInstrukcijaDgv.DataSource = DohvatiInstrukcije();
            PopisOdradenihInstrukcijaDgv.Columns["korisnik_ID"].Visible = false;
        }

        private object DohvatiInstrukcije()
        {
            using (var context = new PI2301_DBEntities())
            {
                DateTime currentDate = DateTime.Now;
                var query = from instrukcija in context.Instrukcijas
                            join termin in context.Termins on instrukcija.instrukcija_ID equals termin.instrukcija_ID
                            join pripada in context.pripadas on termin.termin_ID equals pripada.termin_ID
                            join kor in context.Korisniks on pripada.korisnik_ID equals korisnik.korisnik_ID
                            join korisnik in context.Korisniks on instrukcija.Korisnik.korisnik_ID equals korisnik.korisnik_ID
                            where termin.vrijeme < currentDate && korisnik.korisnik_ID == kor.korisnik_ID
                            select new
                            {
                                instrukcija.predmet,
                                instrukcija.cijena,
                                instrukcija.trajanje,
                                instrukcija.mjesto,
                                termin.vrijeme,
                                korisnik.ime,
                                korisnik.prezime,
                                korisnik.korisnik_ID
                            };
                return query.ToList();
            }
        }

        private void DodajRecenzijuBtn_Click(object sender, EventArgs e)
        {
            string termin = Convert.ToString(PopisOdradenihInstrukcijaDgv.CurrentRow.Cells["vrijeme"].Value);
            DodavanjeRecenzijeFrm forma = new DodavanjeRecenzijeFrm(OdabraniKorisnik(),termin);
            forma.ShowDialog();
        }

        private Korisnik OdabraniKorisnik()
        {
            Korisnik koris;
            int korisnikId = Convert.ToInt32(PopisOdradenihInstrukcijaDgv.CurrentRow.Cells["korisnik_ID"].Value);
            
            using (var item  = new PI2301_DBEntities())
            {
                var query = (from korisnik in item.Korisniks
                                  where korisnik.korisnik_ID == korisnikId
                                  select korisnik).FirstOrDefault();
                koris = query;
            }
            
            return koris;
        }
    }
}
