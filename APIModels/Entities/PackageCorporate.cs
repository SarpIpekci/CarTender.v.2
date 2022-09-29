using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class PackageCorporate
    {
        [Key, Column(Order = 0)]
        public int CorporateID { get; set; }
        public Corporate Corporate { get; set; }
        [Key, Column(Order = 1)]
        public int PackageID { get; set; }
        public Package Package { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
