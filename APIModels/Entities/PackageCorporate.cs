using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class PackageCorporate
    {
        [Key, Column(Order = 0)]
        public Guid CorporateID { get; set; }
        public Corporate Corporate { get; set; }
        [Key, Column(Order = 1)]
        public Guid PackageID { get; set; }
        public Package Package { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
