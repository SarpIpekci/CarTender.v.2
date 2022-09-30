using System;
using System.ComponentModel.DataAnnotations;

namespace APIModels.Entities
{
    public class CarModification
    {
        public Guid ModificationID { get; set; }
        public Modification Modification { get; set; }
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public bool IsActive { get; set; }
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
