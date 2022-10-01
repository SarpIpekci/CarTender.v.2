using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Car : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Information { get; set; }
        public List<UserCar> UserCars { get; set; }
        public List<CarImage> CarImages { get; set; }
        public TramerInformation TramerInformation { get; set; }
        public BidCar BidCar { get; set; }
        public List<CarValue> CarValues { get; set; }
        public Advert Offer { get; set; }
        public List<CarModification> CarModifications { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public List<UserFavoriteCar> UserFavoriteCars { get; set; }

        public Guid CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public Guid? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }
    }
}
