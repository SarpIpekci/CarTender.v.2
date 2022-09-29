using APIMailSender.Abstract;
using APIMailSender.Model;
using System;
using System.Collections.Generic;

namespace APIMailSender.Concrete
{
    public class MailSender : IMailSender
    {
        private readonly IMailProcessor _mailProcessor;
        private readonly ISmtpSettings _smtpSettings;
        private readonly IDbProcessor _dbProcessor;
        private readonly IMailValidator _mailValidator;
        public MailSender(IMailProcessor mailProcessor, ISmtpSettings smtpSettings, IDbProcessor dbProcessor, IMailValidator mailValidator)
        {
            _mailProcessor = mailProcessor;
            _smtpSettings = smtpSettings;
            _dbProcessor = dbProcessor;
            _mailValidator = mailValidator;
        }

        public MailSendResult Send(MailInfo maiInfo)
        {
            MailSendResult mailSendResult = new MailSendResult();
            mailSendResult.Errors = new List<string>();
            try
            {
                mailSendResult = ValidateInfo(maiInfo, mailSendResult);
                if (!mailSendResult.Success)
                    return mailSendResult;

                _mailProcessor.SendMail(maiInfo, _smtpSettings);
                mailSendResult.Success = true;

                //_dbProcessor.SuccessMailSave(maiInfo);
                return mailSendResult;

            }
            catch (Exception ex)
            {
                mailSendResult.Errors.Add(ex.Message);
                _dbProcessor.DeclineMailSave(maiInfo, mailSendResult.GetErrors);
                mailSendResult.Success = false;
                return mailSendResult;
            }

        }

        private MailSendResult ValidateInfo(MailInfo mailBilgi, MailSendResult mailGonderimSonuc)
        {
            if (!_mailValidator.MailValidate(mailBilgi))
            {
                mailGonderimSonuc.Errors.Add("Mail adresi hatalı, lütfen kontrol edin.");
                _dbProcessor.DeclineMailSave(mailBilgi, "Mail adresi hatalı, lütfen kontrol edin.");
                mailGonderimSonuc.Success = false;
            }
            else
            {
                mailGonderimSonuc.Success = true;
            }

            return mailGonderimSonuc;
        }
    }
}
