using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace In_Struct
{
    public partial class PocetnaFrm : HelperFrm
    {
        public PocetnaFrm()
        {
            InitializeComponent();
            Rotiranje();
            postaviHelp("Pocetna.htm");
        }

        
        private void Rotiranje()
        {
            Image originalnaSlika = pictureBox1.Image;
            Image rotiranaSlika = new Bitmap(originalnaSlika.Width, originalnaSlika.Height);
            using (Graphics g = Graphics.FromImage(rotiranaSlika))
            {
                float kutRotacije = 100f;
                g.TranslateTransform(rotiranaSlika.Width / 2, rotiranaSlika.Height / 2);
                g.RotateTransform(kutRotacije);
                g.TranslateTransform(-rotiranaSlika.Width / 2, -rotiranaSlika.Height / 2);
                g.DrawImage(originalnaSlika, 0, 0);
            }
            pictureBox1.Image = rotiranaSlika;
        }
        

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaFrm prijava = new PrijavaFrm();
            prijava.ShowDialog();
            this.Show();
        }

        private void pregledInstrukcijaNeReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            PopisInstrukcijaNereg nereg = new PopisInstrukcijaNereg();
            nereg.ShowDialog();
            this.Show();
        }

        private void registrirajSeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistracijaFrm rega = new RegistracijaFrm();
            rega.ShowDialog();
            this.Show();
           
        }

        private void PocetnaFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void PocetnaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
        
    }
}
