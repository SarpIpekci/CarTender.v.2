using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidInformation : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string BidName { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? FinishedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public int? ApprovedBy { get; set; }

        [ForeignKey("ApprovedBy")]
        public User Approver { get; set; }
        public int? FinishedBy { get; set; }

        [ForeignKey("FinishedBy")]
        public User Finisher { get; set; }

        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public int? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public List<BidCorporateUser> BidCorporateUser { get; set; }
        public List<BidStatusHistory> BidStatusHistory { get; set; }
        public List<BidCar> BidCars { get; set; }
    }
}
