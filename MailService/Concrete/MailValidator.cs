using APIMailSender.Abstract;
using APIModels.Mail;

namespace APIMailSender.Concrete
{
    public class MailValidator : IMailValidator
    {
        public bool MailValidate(MailInfo mailBilgi)
        {
            return true; //mail gecerli var sayalim. kontroller eklenecek.
        }
    }
}
