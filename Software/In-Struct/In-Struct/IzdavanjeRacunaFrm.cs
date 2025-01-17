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
    public partial class IzdavanjeRacunaFrm : HelperFrm
    {
        Korisnik instruktor;
        public IzdavanjeRacunaFrm(Korisnik korisnik)
        {
            InitializeComponent();
            instruktor = korisnik;
            postaviHelp("IzdavanjeRacuna.htm");
        }

        private void IzdavanjeRacunaFrm_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
            dgvKorisnici.Columns["Instrukcijas"].Visible = false;
            dgvKorisnici.Columns["pripadas"].Visible = false;
            dgvKorisnici.Columns["Racuns"].Visible = false;
            dgvKorisnici.Columns["Recenzijas"].Visible = false;
            dgvKorisnici.Columns["Racuns1"].Visible = false;
            dgvKorisnici.Columns["Recenzijas1"].Visible = false;
            dgvKorisnici.Columns["Uloga"].Visible = false;
            dgvKorisnici.Columns["uloga_ID"].Visible = false;
            dgvKorisnici.Columns["lozinka"].Visible = false;
            dgvKorisnici.Columns["korisnicko_ime"].Visible = false;
            dgvKorisnici.Columns["korisnik_ID"].Visible = false;
        }

        private void OsvjeziKorisnike()
        {
            using (var context = new PI2301_DBEntities())
            {
                DateTime vrijeme = DateTime.Now.AddHours(-24);

                var query = (
                    from p in context.Korisniks
                    where p.korisnik_ID == instruktor.korisnik_ID
                    from ins in p.Instrukcijas
                    from termin in ins.Termins
                    where termin.vrijeme < vrijeme
                    from item in termin.pripadas
                    where !item.racunIzdan
                    select item.Korisnik
                ).Distinct();
                dgvKorisnici.DataSource = query.ToList();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            Termin odabraniTermin = dgvTermini.CurrentRow.DataBoundItem as Termin;
            using (var context = new PI2301_DBEntities())
            {
                pripada pripadaZaAžurirati = context.pripadas.FirstOrDefault(p => p.termin_ID == odabraniTermin.termin_ID && p.korisnik_ID == odabraniKorisnik.korisnik_ID);

                if (pripadaZaAžurirati != null)
                {
                    pripadaZaAžurirati.racunIzdan = true;
                    context.SaveChanges();
                }
            }
            RacunEmail racunEmail = new RacunEmail(odabraniKorisnik, odabraniTermin.Instrukcija);
            racunEmail.posaljiMail();
            OsvjeziKorisnike();
        }

        private void dgvKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            List<Termin> terminiUKojimaJeKorisnik = new List<Termin>();

            using (var context = new PI2301_DBEntities())
            {
                Korisnik instruktorovKorisnik = context.Korisniks.Include("Instrukcijas.Termins.pripadas.Korisnik").FirstOrDefault(k => k.korisnik_ID == instruktor.korisnik_ID);

                if (instruktorovKorisnik != null)
                {
                    foreach (Instrukcija ins in instruktorovKorisnik.Instrukcijas)
                    {
                        foreach (Termin termin in ins.Termins)
                        {
                            if (termin.vrijeme < DateTime.Now.AddHours(-24))
                            {
                                foreach (pripada item in termin.pripadas)
                                {
                                    if (item.racunIzdan == false && item.Korisnik.korisnik_ID == odabraniKorisnik.korisnik_ID)
                                    {
                                        terminiUKojimaJeKorisnik.Add(termin);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dgvTermini.DataSource = terminiUKojimaJeKorisnik.ToList();
            dgvTermini.Columns["termin_ID"].Visible = false;
            dgvTermini.Columns["instrukcija_ID"].Visible = false;
            dgvTermini.Columns["termin_ID"].Visible = false;
            dgvTermini.Columns["Instrukcija"].Visible = false;
            dgvTermini.Columns["Racuns"].Visible = false;
            dgvTermini.Columns["pripadas"].Visible = false;
        }

    }
}
