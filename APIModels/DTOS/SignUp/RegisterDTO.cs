using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIModels.DTOS.SignUp
{
    public class RegisterDTO
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public bool IsCorporate { get; set; }
    }
}
