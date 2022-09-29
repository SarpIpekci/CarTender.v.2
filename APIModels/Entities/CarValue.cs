using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class CarValue
    {
        [Key, Column(Order = 0)]
        public int CarID { get; set; }
        public Car Car { get; set; }

        [Key, Column(Order = 1)]
        public int CarValueID { get; set; }
        public CarDetailValue CarDetailValue { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
