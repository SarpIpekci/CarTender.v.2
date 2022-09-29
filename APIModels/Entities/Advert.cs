using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Advert : BaseEntity, ICreateableEntity
    {
        public string Header { get; set; }
        public decimal PrePrice { get; set; }
        public decimal Price { get; set; }
        public string Information { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
    }
}
