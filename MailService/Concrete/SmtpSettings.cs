using APIMailSender.Abstract;
using MailService.Model;
using System.Net;
using System.Net.Mail;

namespace APIMailSender.Concrete
{
    public class SmtpSettings : ISmtpSettings
    {
        private SmtpSetting _smtpAyar;
        private SmtpSetting smtpAyarGetir()
        {
            //Veritabanindan al.
            //Singleton olarak tasarla.
            _smtpAyar = new SmtpSetting();
            _smtpAyar.Host = "smtp.gmail.com";
            _smtpAyar.Port = 587;
            _smtpAyar.UserName = "infocartender@gmail.com";
            _smtpAyar.Password = "paczonwudhcxehdn";
            _smtpAyar.UseSSL = true;
            _smtpAyar.Title = "Test Kişisi";

            return _smtpAyar;
        }



        public SmtpClient GetSmtpClientInfo()
        {
            SmtpSetting smtpAyar = smtpAyarGetir();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = smtpAyar.Host;
            smtpClient.Port = smtpAyar.Port;
            smtpClient.EnableSsl = smtpAyar.UseSSL;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(smtpAyar.UserName, smtpAyar.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.Timeout = 3000;

            return smtpClient;
        }

        public string GetSenderMailInfo()
        {
            return _smtpAyar.UserName;
        }

        public string GetSenderTitleInfo()
        {
            return _smtpAyar.Title;
        }
    }
}
