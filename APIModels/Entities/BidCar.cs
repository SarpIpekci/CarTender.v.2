using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidCar : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public int BidID { get; set; }
        public int CarID { get; set; }
        public decimal StartPrice { get; set; }
        public decimal MinimumPrice { get; set; }
        [ForeignKey("BidID")]
        public BidInformation BidInformation { get; set; }
        [ForeignKey("CarID")]
        public Car Car { get; set; }
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        public int? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
