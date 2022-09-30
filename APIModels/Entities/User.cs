using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string FirstAndLastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsCorporate { get; set; }
        public string Information { get; set; }
        public bool IsApproved { get; set; }
        public bool IsEmailVerificated { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Guid? ApprovedBy { get; set; }
        [ForeignKey("ApprovedBy")]
        public User Approver { get; set; }

        public Guid RoleID { get; set; }
        public Role Role { get; set; }

        public List<UserCar> UserCars { get; set; }
        //public List<CarBuyerInformation> CarBuyerInformations { get; set; }
        public List<Message> Messages { get; set; }
        public List<UserFavoriteCar> UserFavoriteCars { get; set; }
        public List<BidInformation> BidInformations { get; set; }
        public List<BidCorporateUser> BidCorporateUsers { get; set; }
        public List<CorporateUser> CorporateUsers { get; set; }

    }
}
