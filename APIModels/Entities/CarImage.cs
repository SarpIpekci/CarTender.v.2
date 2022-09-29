namespace APIModels.Entities
{
    public class CarImage : BaseEntity
    {
        public int CarID { get; set; }
        public string ImagePath { get; set; }
        public Car Car { get; set; }
    }
}
