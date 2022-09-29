using APIMailSender.Abstract;
using APIMailSender.Model;
using System.Net.Mail;

namespace APIMailSender.Concrete
{
    public class MailProcessor : IMailProcessor
    {
        public void SendMail(MailInfo mailBilgi, ISmtpSettings smtpAyarlayan)
        {
            SmtpClient smtpClient = smtpAyarlayan.GetSmtpClientInfo();
            MailMessage ePosta = new MailMessage();

            //mail gonderecek hesap.
            ePosta.From = new MailAddress(smtpAyarlayan.GetSenderMailInfo(), smtpAyarlayan.GetSenderTitleInfo());

            //mail gonderilecek e-posta adresleri.
            mailBilgi.GonderilecekEpostaAdresleri.ForEach(x => { ePosta.To.Add(x); });

            //Bilgilendirme olarak eklenecek mail adresleri.
            mailBilgi.CcEpostaAdresleri?.ForEach(x => { ePosta.CC.Add(x); });

            //Gizli olarak eklenecek mail adresleri.
            mailBilgi.BccEpostaAdresleri?.ForEach(x => { ePosta.Bcc.Add(x); });

            //mailin konusu.
            ePosta.Subject = mailBilgi.Konu;

            //mail icerigi html olarak gonderilsin.
            ePosta.IsBodyHtml = true;

            //mail icerigi.
            ePosta.Body = mailBilgi.Icerik;
            // ekleri temizledik.
            ePosta.Attachments.Clear();

            //mail ek dosyalari eklendi.
            mailBilgi.EklenecekDosyaAdresleri?.ForEach(x => { ePosta.Attachments.Add(new Attachment(x)); });

            //Mail gonderiliyor.
            smtpClient.Send(ePosta);
        }
    }
}
