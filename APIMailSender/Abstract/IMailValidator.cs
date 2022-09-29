using APIMailSender.Model;

namespace APIMailSender.Abstract
{
    public interface IMailValidator
    {
        bool MailValidate(MailInfo mailBilgi);
    }
}
