using System;
using System.ComponentModel.DataAnnotations;

namespace APIModels.Entities.BaseEntities
{
    public abstract class UnityEntity : ICreateableEntity, IModifiedEntity
    {
        public bool IsActive { get; set; } = true;
        [Timestamp]
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; } = 1;
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
