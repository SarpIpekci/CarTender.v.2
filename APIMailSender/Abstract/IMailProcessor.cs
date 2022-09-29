using APIMailSender.Model;

namespace APIMailSender.Abstract
{
    public interface IMailProcessor
    {
        void SendMail(MailInfo mailBilgi, ISmtpSettings smtpAyarlayan);
    }
}
