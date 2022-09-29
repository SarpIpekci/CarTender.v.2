using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CarStatusHistory : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string Information { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }


        public int CarStatuID { get; set; }
        [ForeignKey("CarStatuID")]
        public Status CarStatus { get; set; }

        public int? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
