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
    public partial class DaniUC : UserControl
    {
        public static int staticDan;
        public DaniUC()
        {
            InitializeComponent();
        }

        private void DaniUC_Load(object sender, EventArgs e)
        {

        }

        public void Dani(int brojDana)
        {
            lblDan.Text = brojDana + "";
        }

        private void DaniUC_Click(object sender, EventArgs e)
        {
            staticDan = int.Parse(lblDan.Text);
            DetaljiInstrukcijeKalendarFrm detalji = new DetaljiInstrukcijeKalendarFrm();
            detalji.ShowDialog();
        }

    }
}
