using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class BidCar : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public Guid BidID { get; set; }
        public Guid CarID { get; set; }
        public decimal StartPrice { get; set; }
        public decimal MinimumPrice { get; set; }
        [ForeignKey("BidID")]
        public BidInformation BidInformation { get; set; }
        [ForeignKey("CarID")]
        public Car Car { get; set; }
        public Guid CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        public Guid? ModifiedBy { get; set; }
        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
    }
}
