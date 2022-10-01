using System;

namespace APIModels.Entities
{
    public class CarImage : BaseEntity
    {
        public Guid CarID { get; set; }
        public string ImagePath { get; set; }
        public Car Car { get; set; }
    }
}
