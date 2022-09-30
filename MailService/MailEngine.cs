using APIMailSender.Concrete;
using APIModels.Mail;
using MailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService
{
    public class MailEngine
    {
        public MailSendResult MailGonder(MailInfo mailgBilgi)
        {
            MailSender mailGonderen = new MailSender(new MailProcessor(), new SmtpSettings(), new DbProcessor(), new MailValidator());
            return mailGonderen.Send(mailgBilgi);
        }
    }
}
