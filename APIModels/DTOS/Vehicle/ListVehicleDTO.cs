using System;

namespace APIModels.DTOS.Vehicle
{
    public class ListVehicleDTO
    {
        public int CarID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string CarStatus { get; set; }
        public string AdderUser { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
