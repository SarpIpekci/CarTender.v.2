using System.Collections.Generic;

namespace APIModels.Mail
{
    public class MailInfo
    {
        public List<string> ReceiveMails { get; set; }
        public List<string> CCMails { get; set; }     //Bilgilendirilecek e-posta adresleri
        public List<string> BCCMails { get; set; }    //Gizli olarak eklenecek e-posta adresleri
        public string Topic { get; set; }
        public string Content { get; set; }
        public List<string> AttachementFolders { get; set; }
    }
}
