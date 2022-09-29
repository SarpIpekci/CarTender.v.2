using System;

namespace APIModels.Entities
{
    public interface IModifiedEntity
    {
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
