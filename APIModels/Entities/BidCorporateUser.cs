using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidCorporateUser : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public int BidID { get; set; }

        public int UserID { get; set; }
        public int? CorporateID { get; set; }


        public Corporate Corporate { get; set; }
        public User User { get; set; }
        public BidInformation BidInformation { get; set; }
        public List<BidUserOffer> BidUserOffers { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }
    }
}
