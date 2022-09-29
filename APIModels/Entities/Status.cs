using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Status : BaseEntity
    {
        public string Code { get; set; }
        public string StatusName { get; set; }
        public List<BidStatusHistory> BidStatusHistories { get; set; }
        public List<CarStatusHistory> CarStatusHistories { get; set; }
        public List<CorporateStatusHistory> CorporateStatusHistories { get; set; }
        public List<AdvertStatusHistory> OfferStatusHistories { get; set; }
        public List<TramerStatusHistory> TramerStatusHistories { get; set; }
    }
}
