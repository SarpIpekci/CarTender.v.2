namespace APIModels.Entities
{
    public class UserFavoriteCar
    {
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
