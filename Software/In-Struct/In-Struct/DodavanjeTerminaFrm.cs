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
    public partial class DodavanjeTerminaFrm : HelperFrm
    {
        Instrukcija instrukcija;
        public DodavanjeTerminaFrm(Instrukcija inst)
        {
            InitializeComponent();
            instrukcija = inst;
            postaviHelp("DodavanjeTermina.htm");
        }
        private void OdustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajTerminBtn_Click(object sender, EventArgs e)
        {
            using (var item = new PI2301_DBEntities())
            {
                string brojMjesta = BrojMjestaTxtBox.Text;
                string brojSati = vrijemePicker.Text;
                string datum = datumPicker.Text;
                string vrijeme = $"{brojSati},{datum}";
                Termin termin = new Termin
                {
                    instrukcija_ID=instrukcija.instrukcija_ID,
                    broj_mjesta = int.Parse(brojMjesta),
                    vrijeme = DateTime.Parse(vrijeme)
                };
                item.Termins.Add(termin);
                item.SaveChanges();
            }
            Close();
        }

        private void DodavanjeTerminaFrm_Load(object sender, EventArgs e)
        {
            datumPicker.Format = DateTimePickerFormat.Custom;
            datumPicker.CustomFormat = "MM/dd/yyyy";

            vrijemePicker.Format = DateTimePickerFormat.Custom;
            vrijemePicker.CustomFormat = "hh:mm:ss";
        }
    }
}
