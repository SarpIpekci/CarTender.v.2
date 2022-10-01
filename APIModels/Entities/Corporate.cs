using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Corporate : BaseEntity, ICreateableEntity
    {
        public string CorporateName { get; set; }
        public string CorporatePhone { get; set; }
        public Guid AddressInformationID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Guid CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User Adder { get; set; }
        [ForeignKey("AddressInformationID")]
        public AddressInformation AddressInformation { get; set; }
        public PackageCorporate PackageCorporate { get; set; }
        public List<BidCorporateUser> BidCorporateUsers { get; set; }
        public List<CorporateUser> CorporateUsers { get; set; }
    }
}
