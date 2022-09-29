using System.ComponentModel.DataAnnotations;

namespace APIModels.Entities
{
    public interface IEntity<TKey>
    {
        public TKey ID { get; set; }
        public bool IsActive { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
