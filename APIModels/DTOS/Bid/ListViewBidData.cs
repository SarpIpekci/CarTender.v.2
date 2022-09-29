using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace APIModels.DTOS.Bid
{
    public class ListViewBidData
    {
        public List<SelectListItem> BidStatusList { get; set; }
        public string BidName { get; set; }
        public int BidStatusId { get; set; }
        public bool IsCorporate { get; set; }
        public List<BidInformationDTO> BidInformationList { get; set; }
    }
}
