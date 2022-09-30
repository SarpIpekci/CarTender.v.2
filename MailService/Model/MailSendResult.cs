using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService.Model
{
    public class MailSendResult
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }

        public string GetErrors
        {
            get { return Errors.Aggregate((x, y) => x + "\r\n" + y); }
            private set { }
        }
    }
}
