using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class AdvertStatusHistory : BaseEntity, IModifiedEntity, ICreateableEntity
    {
        public string Information { get; set; }

        public Guid AdvertID { get; set; }
        public Advert Advert { get; set; }

        public Guid StatuID { get; set; }
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
