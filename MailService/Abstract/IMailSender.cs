
using APIModels.Mail;
using MailService.Model;

namespace APIMailSender.Abstract
{
    public interface IMailSender
    {
        public MailSendResult Send(MailInfo maiInfo);
    }
}
