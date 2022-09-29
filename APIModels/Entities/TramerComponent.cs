using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class TramerComponent : BaseEntity, ICreateableEntity
    {
        public string TramerComponentName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        public List<TramerInformationComponent> TramerComponentStatus { get; set; }
    }
}
