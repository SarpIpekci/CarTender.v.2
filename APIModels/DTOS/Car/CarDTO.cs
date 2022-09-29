using APIModels.DTOS.Vehicle;
using System;

namespace APIModels.DTOS.Car
{
    public class CarDTO
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int CarStatuID { get; set; }
        public string Information { get; set; }
        public ListVehicleDTO carComponentDetail { get; set; }
    }
}
