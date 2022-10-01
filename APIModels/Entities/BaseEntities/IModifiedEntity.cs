using System;

namespace APIModels.Entities
{
    public interface IModifiedEntity
    {
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
