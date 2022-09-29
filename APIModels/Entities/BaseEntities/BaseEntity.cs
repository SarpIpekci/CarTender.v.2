using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public abstract class BaseEntity : IEntity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public bool IsActive { get; set; } = true;
        [Timestamp]
        public byte[] Version { get; set; }

    }
}
