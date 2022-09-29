using System.Net.Mail;

namespace APIMailSender.Abstract
{
    public interface ISmtpSettings
    {
        SmtpClient GetSmtpClientInfo();
        string GetSenderMailInfo();
        string GetSenderTitleInfo();
    }
}
