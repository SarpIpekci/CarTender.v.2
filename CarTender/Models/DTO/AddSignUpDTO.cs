using System;

namespace CarTender.Models.DTO
{
    public class AddSignUpDTO
    {
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsCorporate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int RoleID { get; set; }
    }
}
