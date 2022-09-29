using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public List<RoleAuthorization> RoleAutherizations { get; set; }
    }
}
