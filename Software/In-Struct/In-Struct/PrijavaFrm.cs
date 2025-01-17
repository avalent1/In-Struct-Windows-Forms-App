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
    public partial class PrijavaFrm : HelperFrm
    {
        public PrijavaFrm()
        {
            InitializeComponent();
            postaviHelp("Prijava.htm");
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijaviSeButton_Click(object sender, EventArgs e)
        {
            
            prijaviMe();
            
        }

        private void prijaviMe()
        {
            bool pronaden = false;
            Korisnik trenutni = null;
            
            
            using (var context = new PI2301_DBEntities())
            {
                foreach (var korisnik in context.Korisniks)
                {

                    if (korisnik.korisnicko_ime == korImeTxtBox.Text && korisnik.lozinka == lozinkaTxtBox.Text && korisnik.uloga_ID == 1)
                    {
                        pronaden = true;
                        trenutni = korisnik;
                        Autentikacija.SpremiKorisnika(korisnik);

                    }
                    else if (korisnik.korisnicko_ime == korImeTxtBox.Text && korisnik.lozinka == lozinkaTxtBox.Text && korisnik.uloga_ID == 2)
                    {
                        pronaden = true;
                        trenutni = korisnik;
                        Autentikacija.SpremiKorisnika(korisnik);
                    }
                    else if (korImeTxtBox.Text == string.Empty || lozinkaTxtBox.Text == string.Empty)
                    {
                        pronaden = false;
                        MessageBox.Show("Morate unijeti i korisničko ime i lozinku!");
                        return;
                    }
                    
                }
            }
            if (pronaden == false)
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu točni!");
                return;
            }
            if (trenutni.uloga_ID == 1)
            {
                this.Hide();
                _2FaktorAutent form = new _2FaktorAutent(trenutni);
                form.ShowDialog();
            }
            else if (trenutni.uloga_ID == 2)
            {
                this.Hide();
                _2FaktorAutent form = new _2FaktorAutent(trenutni);
                form.ShowDialog();
            }
        }

        private void lozinkaTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) prijaviMe();
        }

        private void PrijavaFrm_Load(object sender, EventArgs e)
        {
            sakrijPokaziLozinku.Enabled = false;
        }

        private void sakrijPokaziLozinku_Click(object sender, EventArgs e)
        {
            if (lozinkaTxtBox.PasswordChar == '●')
            {
                lozinkaTxtBox.PasswordChar = '\0';
                sakrijPokaziLozinku.Text = "Sakrij lozinku";
            }
            else
            {
                lozinkaTxtBox.PasswordChar = '●';
                sakrijPokaziLozinku.Text = "Prikaži lozinku";
            }
        }

        private void lozinkaTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (lozinkaTxtBox.Text == "")
            {
                sakrijPokaziLozinku.Enabled = false;
                lozinkaTxtBox.PasswordChar = '●';
                sakrijPokaziLozinku.Text = "Prikaži lozinku";
            }
            else
            {
                sakrijPokaziLozinku.Enabled = true;
            }
        }
    }
}
