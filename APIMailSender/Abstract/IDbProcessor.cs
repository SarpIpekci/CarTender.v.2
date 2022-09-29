﻿using APIMailSender.Model;

namespace APIMailSender.Abstract
{
    public interface IDbProcessor
    {
        void SuccessMailSave(MailInfo mailBilgi);
        void DeclineMailSave(MailInfo mailBilgi, string mesaj);
    }
}
