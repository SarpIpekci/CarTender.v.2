using System;
using System.ComponentModel.DataAnnotations;

namespace APIModels.Entities.BaseEntities
{
    public abstract class ModifiedEntity : IModifiedEntity
    {
        public bool IsActive { get; set; } = true;
        [Timestamp]
        public byte[] Version { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
