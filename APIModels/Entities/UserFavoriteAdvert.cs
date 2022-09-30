using System;

namespace APIModels.Entities
{
    public class UserFavoriteCar
    {
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid UserID { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
