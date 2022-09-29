using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class RoleAuthorization
    {
        [Key, Column(Order = 0)]
        public int RoleID { get; set; }

        [Key, Column(Order = 1)]
        public int AuthorizationID { get; set; }

        [Key, Column(Order = 2)]
        public int PageAuthorizationID { get; set; }

        public Role Role { get; set; }
        public Authorization Authorization { get; set; }
        public PageAuthorization PageAuthorization { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
