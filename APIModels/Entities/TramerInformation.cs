using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class TramerInformation : BaseEntity, ICreateableEntity, IModifiedEntity
    {
        public decimal TramerPrice { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public Guid CarID { get; set; }
        public Car Car { get; set; }

        public Guid CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }

        public Guid? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public User Modifier { get; set; }

        public List<TramerInformationComponent> TramerComponentStatus { get; set; }
    }
}
