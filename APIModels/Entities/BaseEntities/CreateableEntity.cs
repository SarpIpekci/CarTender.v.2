using System;
using System.ComponentModel.DataAnnotations;

namespace APIModels.Entities
{
    public abstract class CreateableEntity : ICreateableEntity
    {
        public bool IsActive { get; set; } = true;
        [Timestamp]
        public byte[] Version { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
    }
}
