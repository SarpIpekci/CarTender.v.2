using System.Collections.Generic;

namespace APIModels.Entities
{
    public class CorporateRole : BaseEntity
    {
        public string RoleName { get; set; }
        public List<CorporateUser> CorporateUsers { get; set; }
    }
}
