using APIMailSender.Abstract;
using APIMailSender.Model;

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
