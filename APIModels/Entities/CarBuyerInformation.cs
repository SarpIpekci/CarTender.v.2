using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CarBuyerInformation : BaseEntity
    {
        public int CarID { get; set; }

        [ForeignKey("CarID")]
        public Car Car { get; set; }

        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        public decimal Price { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
