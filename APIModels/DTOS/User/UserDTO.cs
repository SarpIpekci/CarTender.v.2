using System;

namespace APIModels.DTOS.User
{
    public class UserDTO
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public bool IsCorporate { get; set; }
        public string Information { get; set; }
    }
}
