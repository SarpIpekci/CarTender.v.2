using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public Guid ID { get; set; }

        public bool IsActive { get; set; } = true;
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
