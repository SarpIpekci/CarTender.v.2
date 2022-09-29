using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidStatusHistory : BaseEntity, IModifiedEntity, ICreateableEntity
    {

        public string Information { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public int? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public int BidID { get; set; }
        public BidInformation Bid { get; set; }

        public int StatuID { get; set; }

        [ForeignKey("StatuID")]
        public Status Status { get; set; }
    }
}
