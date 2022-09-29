using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace APIModels.DTOS.Vehicle
{
    public class ListViewOfferData
    {
        public int MarkaID { get; set; }
        public List<SelectListItem> MarkaList { get; set; }
        public int ModelID { get; set; }
        public List<SelectListItem> ModelList { get; set; }
        public int CarStatusID { get; set; }
        public List<SelectListItem> CarStatuList { get; set; }
        public List<ListVehicleDTO> CarList { get; set; }
    }
}
