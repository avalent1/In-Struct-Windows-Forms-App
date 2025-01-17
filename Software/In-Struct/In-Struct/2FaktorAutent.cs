using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace In_Struct
{
    public partial class _2FaktorAutent : HelperFrm
    {
        Korisnik korisnik;
        Random r = new Random();
        int kod = 0;
        public _2FaktorAutent(Korisnik kor)
        {
            InitializeComponent();
            korisnik = kor;
            postaviHelp("2faktorAutentifikacija.htm");
        }
        


        private void _2FaktorAutent_Load(object sender, EventArgs e)
        {
            try
            {
                string senderEmail = "instructJAKA@gmail.com";
                string senderPassword = "owlkasxhqbynipdl";
                string receiverEmail = $"{korisnik.email}";
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(receiverEmail);
                mail.Subject = "Potvrdite svoju prijavu - InStruct App";
                kod = r.Next(10000,99999);
                //mail.Body = "<html><body><h1 style = 'color: #333333;'> Kod za logiranje je:</h1> <p style = 'color: #666666;'> " + kod + "</p></body></html> ";
                //mail.Body = "<html><head><style>body {font - family: Arial, sans - serif;background - color: #F0F0F0;}h1 {color: #333333;}p {color: #666666;}</style></head><body><h1> Kod za logiranje je: </h1><p>" + kod + "</p></body></html>";
                mail.Body = @"<html><head><style>body{font-family:Arial,sans-serif;background-color:#F0F0F0;margin:0;padding:0}.container{max-width:600px;margin:0 auto;padding:20px}.header{background-color:#004E92;padding:20px;text-align:center}.header h1{color:#FFFFFF;font-size:24px;margin:0}.content{background-color:#FFFFFF;padding:20px}.footer{background-color:#F0F0F0;padding:10px;text-align:center;font-size:12px;color:#666666}</style></head><body><div class=""container""><div class=""header""><h1>InStruct App</h1></div><div class=""content""><h2>Potvrdite svoju prijavu u aplikaciju</h2><p>Pozdrav,</p><p>Hvala vam što koristite InStruct aplikaciju! Da biste dovršili prijavu, molimo koristite sljedeći verifikacijski kod za prijavu:</p><p style=""text-align:center; font-size: 20px; color: #004E92;""><strong>Verifikacijski kod: " + kod + @"</strong></p><p>Ako se niste prijavili u InStruct, molimo Vas da provjerite svoje podatke.</p><p>Srdačan pozdrav,<br>InStruct Tim</p></div><div class=""footer""><p>Ovaj email je poslan od strane InStruct aplikacije. Molimo ne odgovarajte na ovaj email.</p></div></div></body></html>";

                mail.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    Port =587,
                    Credentials = new NetworkCredential(senderEmail,senderPassword),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true
                };

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri slanju poruke " + ex.Message);
                
            }
        }

        private void potvrdiKod()
        {
            if (kod.ToString() != KodBtn.Text)
            {
                MessageBox.Show("Krivi kod");
            }
            else
            {
                if (korisnik.uloga_ID == 1)
                {
                    PocetnaUcenik rega = new PocetnaUcenik(korisnik);
                    Autentikacija.SpremiKorisnika(korisnik);
                    this.Hide();
                    rega.ShowDialog();
                }
                else
                {
                    PocetnaInstruktor rega1 = new PocetnaInstruktor();
                    Autentikacija.SpremiKorisnika(korisnik);
                    this.Hide();
                    rega1.ShowDialog();
                }
            }
        }
        private void PotvrdiBtn_Click(object sender, EventArgs e)
        {
            potvrdiKod();
        }

        private void KodBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) potvrdiKod();
        }
    }
}
