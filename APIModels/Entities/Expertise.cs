using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{   //todo : Tartışılacak
    public class Expertise : BaseEntity
    {
        public string ExpertiseName { get; set; }
        public Guid AddressInformationID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [ForeignKey("AddressInformationID")]
        public AddressInformation AddressInformation { get; set; }
    }
}
