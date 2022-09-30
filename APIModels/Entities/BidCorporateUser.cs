using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidCorporateUser : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public Guid BidID { get; set; }

        public Guid UserID { get; set; }
        public Guid? CorporateID { get; set; }


        public Corporate Corporate { get; set; }
        public User User { get; set; }
        public BidInformation BidInformation { get; set; }
        public List<BidUserOffer> BidUserOffers { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }
    }
}
