using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace In_Struct
{
    public class RacunEmail
    {
        Korisnik instruktor = Autentikacija.VratiImeKorisnika();
        Korisnik ucenik;
        Instrukcija odabranaInstrukcija;

        public RacunEmail(Korisnik korisnik, Instrukcija instrukcija)
        {
            ucenik = korisnik;
            odabranaInstrukcija = instrukcija;
        }

        public void posaljiMail()
        {
            string senderEmail = "instructJAKA@gmail.com";
            string senderPassword = "owlkasxhqbynipdl";
            string receiverEmail = $"{ucenik.email}";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(receiverEmail);
            mail.Subject = "Račun za usluge instrukcija - InStruct App";

            //string receiptDetails = GenerateReceiptDetails();
            string receiptItems = GenerateReceiptItems();
            string imeKupca = $"{ucenik.ime} {ucenik.prezime}";
            string nazivTvrtke = "InStruct d.o.o.";
            string adresa = "Kriveljski put 9";
            string postanski = "42000";
            string grad = "Varazdin";
            string oib = "10987654321";
            string datumIzdavanja = DateTime.Now.Date.ToString("dd.MM.yyyy");
            string mjestoIzdavanja = $"{odabranaInstrukcija.mjesto}";
            string vrijemeIzdavanja = DateTime.Now.TimeOfDay.ToString(@"hh\:mm");
            string datumDospjeca = DateTime.Now.AddDays(15).ToString("dd.MM.yyyy");
            string iban = "IBAN HRxxxxxxxxxxxxxxxxxxx";
            string nacinPlacanja = "Transakcijski račun";

            string racunIzdao = "Dokument izdao: " + $"{instruktor.ime}" + " " + $"{instruktor.prezime}";
            //string receiptDetails = $"Kupac: {imeKupca}<br>Naziv tvrtke: {nazivTvrtke}<br>Adresa i Kućni broj: {adresa}<br>Poštanski broj i Grad: {postanski} {grad}<br>{oib}<br>{datumIzdavanja}<br>{mjestoIzdavanja}<br>{vrijemeIzdavanja}<br>{datumDospjeca}<br>IBAN: {iban}<br>{racunIzdao}<br><br>{nacinPlacanja}<br><br>";

            mail.Body = $@"<html><head><style>body{{font-family:Arial,sans-serif;background-color:#F0F0F0;margin:0;padding:0}}.container{{max-width:600px;margin:0 auto;padding:20px;border:2px solid #40e0d0;border-radius:10px;box-shadow:0 0 10px rgba(0,0,0,.1)}}.header{{background-color:#40e0d0;padding:20px;text-align:center}}.header h1{{color:#fff;font-size:30px;margin:0}}.content{{background-color:#fff;padding:20px;margin-top:20px;border-radius:5px;box-shadow:0 2px 5px rgba(0,0,0,.1)}}.content h2{{color:#40e0d0;font-size:24px;margin-bottom:10px}}.receipt-table{{width:100%;border-collapse:collapse;margin-top:20px}}.receipt-table th,.receipt-table td{{border:1px solid #40e0d0;padding:8px;text-align:left}}.receipt-table th{{background-color:#40e0d0;color:#fff;font-weight:bold}}.footer{{background-color:#F0F0F0;padding:10px;text-align:center;font-size:12px;color:#666;margin-top:20px}}</style></head><body><div class=""container""><div class=""header""><h1>InStruct App</h1></div><div class=""content""><h2>Račun za usluge</h2><p>Pozdrav,</p><p>Hvala Vam što koristite In-Struct aplikaciju za instrukcije! U nastavku se nalazi vaš račun: </p><table class=""receipt-table""><tr><th>Kupac</th><td>{imeKupca}</td></tr><tr><th>Naziv tvrtke</th><td>{nazivTvrtke}</td></tr><tr><th>Adresa</th><td>{adresa}</td></tr><tr><th>Poštanski broj</th><td>{postanski}</td></tr><tr><th>Grad</th><td>{grad}</td></tr><tr><th>OIB</th><td>{oib}</td></tr><tr><th>Datum izdavanja</th><td>{datumIzdavanja}</td></tr><tr><th>Mjesto izdavanja</th><td>{mjestoIzdavanja}</td></tr><tr><th>Vrijeme izdavanja</th><td>{vrijemeIzdavanja}</td></tr><tr><th>Datum dospjeća</th><td>{datumDospjeca}</td></tr><tr><th>IBAN</th><td>{iban}</td></tr><tr><th>Način plaćanja</th><td>{nacinPlacanja}</td></tr></table> {racunIzdao} {receiptItems}<p>Ako imate pitanja vezano za ovaj racun, slobodno nas kontaktirajte.</p><p>Srdačan pozdrav,<br>InStruct Tim</p></div><div class=""footer""><p>This email was sent by the InStruct App. Please do not reply to this email.</p></div></div></body></html>";
            mail.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, senderPassword),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true
            };

            smtpClient.Send(mail);
        }

        private string GenerateReceiptItems()
        {
            int iznos = odabranaInstrukcija.cijena;
            double cijenaUKunama = iznos * 7.53450;
            string receiptItems = @"<table style=""border-collapse: collapse; width: 100%;"">";
            receiptItems += @"<tr style=""background-color: #f2f2f2;""><th style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">R.br.</th><th style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">Opis usluge</th><th style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">Trajanje (min)</th><th style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">Cijena (EUR)</th></tr>";
            receiptItems += @"<tr><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">1</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">" + "Usluge instrukcija za predmet " + odabranaInstrukcija.predmet + @"</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">" + odabranaInstrukcija.trajanje + @"</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">" + odabranaInstrukcija.cijena + @"</td></tr>";
            receiptItems += @"<tr><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">PDV</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">0,00 </td></tr>";
            receiptItems += @"<tr><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">IZNOS ZA PLATITI</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">" + odabranaInstrukcija.cijena + @"</td></tr>";
            receiptItems += @"<tr><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px;"">1,00 EUR =7,53450 HRK</td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;""></td><td style=""border: 1px solid #ddd; padding: 8px; border-radius: 5px; text-align: center;"">" + cijenaUKunama + " HRK" + @"</td></tr>";
            receiptItems += "</table></div>";

            return receiptItems;
        }
    }
}