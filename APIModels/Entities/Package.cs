using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Package : BaseEntity
    {
        public string PackageName { get; set; }
        public int BidCount { get; set; }
        public List<PackageCorporate> PackageCorporate { get; set; }
    }
}
