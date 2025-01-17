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
    public partial class RegistracijaFrm : Form
    {
        public RegistracijaFrm()
        {
            InitializeComponent();
            PostaviHelp();
        }
        private void PostaviHelp()
        {
            string appPutanja = Application.StartupPath;
            string nazivFilea = @"Pomoc\In-Struct-Help.chm";
            string putanja = appPutanja + @"\" + nazivFilea;
            string stranica = "Registracija.htm";
            helpProvider1.HelpNamespace = putanja;
            helpProvider1.SetHelpKeyword(this, stranica);
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrirajSeButton_Click(object sender, EventArgs e)
        {
            using (var item = new PI2301_DBEntities())
            {
                if (imeTxtBox.Text == string.Empty || prezimeTxtBox.Text == string.Empty || korImeTxtBox.Text == string.Empty || lozinkaTxtBox.Text == string.Empty
                    || emailTxtBox.Text == string.Empty || brojTelefonaTxtBox.Text == string.Empty)
                {
                    MessageBox.Show("Sva polja su obavezna!\nMolimo ispunite ih");
                }
                else
                {
                    string ime = imeTxtBox.Text;
                    string prezime = prezimeTxtBox.Text;
                    string kor_ime = korImeTxtBox.Text;
                    string lozinka = lozinkaTxtBox.Text;
                    string email = emailTxtBox.Text;
                    string brojtel = brojTelefonaTxtBox.Text;
                    int id = OdabranaUloga().uloga_ID;
                    bool pronaden = false;
                    foreach (var kor in item.Korisniks)
                    {
                        if (kor.korisnicko_ime == kor_ime && kor.email == email)
                        {
                            pronaden = true;
                            MessageBox.Show("Korisničko ime ili email su već zauzeti!");
                        }
                        if (kor.korisnicko_ime == kor_ime)
                        {
                            pronaden = true;
                            MessageBox.Show("Korisničko ime je zauzeto!");
                        }
                        if (kor.korisnicko_ime == kor_ime && kor.email == email)
                        {
                            pronaden = true;
                            MessageBox.Show("Email je već zauzet!");
                        }
                        if (!emailTxtBox.Text.Contains("@"))
                        {
                            MessageBox.Show("Krivo unesena email adresa");
                        }
                    }
                    if (pronaden == false)
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            ime = ime,
                            prezime = prezime,
                            korisnicko_ime = kor_ime,
                            lozinka = lozinka,
                            email = email,
                            telefon = brojtel,
                            uloga_ID = id
                        };
                        item.Korisniks.Add(korisnik);
                        item.SaveChanges();
                        MessageBox.Show("Uspješno ste se registrirali. Prijavite se");
                        Hide();
                        PrijavaFrm forma = new PrijavaFrm();
                        forma.ShowDialog();
                        
                    }
                }
            }
        }

        private Uloga OdabranaUloga()
        {
            return ulogaComboBox.SelectedValue as Uloga;
        }

        private void RegistracijaFrm_Load(object sender, EventArgs e)
        {
            sakrijPokaziLozinku.Enabled = false;
            ulogaComboBox.DataSource = null;
            ulogaComboBox.DataSource = uloge();
        }

        private object uloge()
        {
            using (var item = new PI2301_DBEntities())
            {
                return item.Ulogas.ToList();
            }
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
            }
            else
            {
                sakrijPokaziLozinku.Enabled = true;
            }
        }
    }
}
