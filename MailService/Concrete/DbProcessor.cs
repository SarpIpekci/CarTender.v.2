using APIMailSender.Abstract;
using APIModels.Mail;

namespace APIMailSender.Concrete
{
    public class DbProcessor : IDbProcessor
    {
        public void SuccessMailSave(MailInfo mailBilgi)
        {
            //throw new NotImplementedException();
        }

        public void DeclineMailSave(MailInfo mailBilgi, string mesaj)
        {
            //throw new NotImplementedException();
        }
    }
}
