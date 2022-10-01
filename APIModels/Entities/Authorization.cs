using System;
using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Authorization : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string AutherizationPath { get; set; }
        public List<RoleAuthorization> RoleAutherizations { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
