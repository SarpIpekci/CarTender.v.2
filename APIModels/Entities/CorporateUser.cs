using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CorporateUser
    {
        [Key, Column(Order = 0)]
        public Guid UserID { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 1)]
        public Guid CorporateID { get; set; }
        public Corporate Corporate { get; set; }

        [Key, Column(Order = 2)]
        public Guid CorporateRoleID { get; set; }
        public CorporateRole CorporateRole { get; set; }

        public bool IsActive { get; set; } = true;

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
