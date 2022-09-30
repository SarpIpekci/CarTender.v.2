using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CarStatusHistory : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string Information { get; set; }

        public Guid CarID { get; set; }
        public Car Car { get; set; }


        public Guid CarStatuID { get; set; }
        [ForeignKey("CarStatuID")]
        public Status CarStatus { get; set; }

        public Guid? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public Guid CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
