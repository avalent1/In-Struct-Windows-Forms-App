using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Struct
{
    public partial class KalendarskiPrikazFrm : Form
    {
        int mjesec, godina;
        public static int staticMjesec, staticGodina;
        DateTime now = DateTime.Now;
        public KalendarskiPrikazFrm()
        {
            InitializeComponent();
        }

        private void KalendarskiPrikazFrm_Load(object sender, EventArgs e)
        {
            inicijalizacijaVarijabliPrikazDana();
        }

        private void inicijalizacijaVarijabliPrikazDana()
        {
            godina = now.Year;
            mjesec = now.Month;
            PrikaziDane();
            NazivMjeseca();
            staticGodina = godina;
            staticMjesec = mjesec;
        }

        private void NazivMjeseca()
        {
            string nazivMjeseca = DateTimeFormatInfo.CurrentInfo.GetMonthName(mjesec);
            mjesecGodina.Text = nazivMjeseca + " " + godina;
        }

        private void PrikaziDane()
        {
            DateTime prviDanMjeseca = new DateTime(godina, mjesec, 1);
            int dani = DateTime.DaysInMonth(godina, mjesec);
            int danUTjednu = Convert.ToInt32(prviDanMjeseca.DayOfWeek.ToString("d")); 

            for (int i = 0; i < danUTjednu; i++)
            {
                PrazanUC prazan = new PrazanUC();
                DayContainer.Controls.Add(prazan);
            }
            for (int i = 1; i <= dani; i++)
            {
                DaniUC daniUMjesecu = new DaniUC();
                daniUMjesecu.Dani(i);
                DayContainer.Controls.Add(daniUMjesecu);
            }
        }

        private void DayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Hide();
            PocetnaInstruktor pocetna = new PocetnaInstruktor();
            pocetna.ShowDialog();
        }

        private void btnMjesecNazad_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            mjesec--;
            staticMjesec = mjesec;
            PrikaziDane();
            NazivMjeseca();
        }

        private void btnMjesecNaprijed_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            mjesec++;
            staticMjesec = mjesec;
            PrikaziDane();
            NazivMjeseca();
        }

    }
}
