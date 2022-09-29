using APIModels.Mail;

namespace APIMailSender.Abstract
{
    public interface IMailValidator
    {
        bool MailValidate(MailInfo mailBilgi);
    }
}
