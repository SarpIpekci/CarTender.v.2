using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidUserOffer : BaseEntity, ICreateableEntity
    {
        public int BidCorporateUserID { get; set; }
        [ForeignKey("BidCorporateUserID")]
        public BidCorporateUser BidCorporateUser { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
    }
}
