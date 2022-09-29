using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CorporateStatusHistory : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public string Information { get; set; }

        public int CorporateID { get; set; }
        public Corporate Corporate { get; set; }

        public int StatuID { get; set; }
        [ForeignKey("StatuID")]
        public Status Status { get; set; }

        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public int? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
