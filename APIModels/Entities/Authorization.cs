using System;
using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Authorization : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string AutherizationPath { get; set; }
        public List<RoleAuthorization> RoleAutherizations { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 1;
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
