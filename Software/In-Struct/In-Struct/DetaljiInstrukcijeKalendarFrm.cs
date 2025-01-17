using In_Struct.Iznimke;
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
    public partial class DetaljiInstrukcijeKalendarFrm : Form
    {
        public PI2301_DBEntities kontekst;
        public DetaljiInstrukcijeKalendarFrm()
        {
            InitializeComponent();
            kontekst = new PI2301_DBEntities();
        }

        private void DetaljiInstrukcijeKalendarFrm_Load(object sender, EventArgs e)
        {
            trazeniTermin();
            dgvTermini.Columns["instrukcija_ID"].Visible = false;
            dgvTermini.Columns["Instrukcija"].Visible = false;
            dgvTermini.Columns["Racuns"].Visible = false;
            dgvTermini.Columns["pripadas"].Visible = false;
            PopuniLabele();
        }
        private void trazeniTermin()
        {
            int korisnikID = Autentikacija.VratiIDKorisnika();
            var query = from p in kontekst.Termins
                        join o in kontekst.Instrukcijas on p.instrukcija_ID equals o.instrukcija_ID
                        where p.vrijeme.Day == DaniUC.staticDan && p.vrijeme.Month == KalendarskiPrikazFrm.staticMjesec
                        && o.instruktor_ID == korisnikID
                        select p;
            dgvTermini.DataSource = query.ToList();
        }

        private Termin odabraniTermin()
        {
            if(dgvTermini.Rows.Count == 0) throw new TerminException("Ne postoje termini na ovaj datum");
            return dgvTermini.CurrentRow.DataBoundItem as Termin;
        }


        private void PopuniLabele()
        {
            Termin odabranaInstrukcija = null;
            try
            {
                odabranaInstrukcija = odabraniTermin();
                lblPredmet.Text = odabranaInstrukcija.Instrukcija.predmet;
                lblCijena.Text = odabranaInstrukcija.Instrukcija.cijena.ToString() + " €";
                lblTrajanje.Text = odabranaInstrukcija.Instrukcija.trajanje.ToString() + " minuta/e";
            }
            catch(TerminException e)
            {
                MessageBox.Show(e.Poruka);
                this.Close();
            }
        }

        private void dgvTermini_SelectionChanged(object sender, EventArgs e)
        {
            PopuniLabele();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetaljiInstrukcijeKalendarFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            kontekst.Dispose();
        }
    }
}
