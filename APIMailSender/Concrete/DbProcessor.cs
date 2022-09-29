using APIMailSender.Abstract;
using APIMailSender.Model;

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
