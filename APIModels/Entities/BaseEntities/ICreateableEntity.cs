using System;

namespace APIModels.Entities
{
    public interface ICreateableEntity
    {
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
