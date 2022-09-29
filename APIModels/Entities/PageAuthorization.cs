using System.Collections.Generic;

namespace APIModels.Entities
{
    public class PageAuthorization : BaseEntity
    {
        public string PageAuthorizationName { get; set; }
        public List<RoleAuthorization> RoleAutherizations { get; set; }
    }
}
