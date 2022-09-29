using APIModels.DTOS.Car;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace APIModels.DTOS.Bid
{
    public class UpdateBidDTO
    {
        public List<SelectListItem> BidStatusList { get; set; }
        public List<CarDTO> BidCars { get; set; }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUserFirstAndLastName { get; set; }
        public string BidName { get; set; }
        public bool IsCorporate { get; set; }
        public int BidStatusID { get; set; }
        public string BidStatusName { get; set; }
        public DateTime? FinishedDate { get; set; }
        public string FinishedUserFirstAndLastName { get; set; }
    }
}
