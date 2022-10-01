using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CorporateStatusHistory : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string Information { get; set; }

        public Guid CorporateID { get; set; }
        public Corporate Corporate { get; set; }

        public Guid StatuID { get; set; }
        [ForeignKey("StatuID")]
        public Status Status { get; set; }

        public Guid CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public Guid? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
