using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    //todo : tartışılacak
    public class AddressInformation : BaseEntity
    {
        //[Key,Column(Order =0)]
        //public int CityID { get; set; }
        //[Key, Column(Order = 1)]
        //public int TownID { get; set; }
        //[Key, Column(Order = 2)]
        //public int DistrictID { get; set; }
        //[Key, Column(Order = 3)]
        public Guid NeighborhoodID { get; set; }
        //public bool IsActive { get; set; }
        //[Timestamp]
        //public byte[] Version { get; set; }
        //[ForeignKey("CityID")]
        //public City City { get; set; }
        //[ForeignKey("TownID")]
        //public Town Town { get; set; }
        //[ForeignKey("DistrictID")]
        //public District District { get; set; }
        [ForeignKey("NeighborhoodID")]
        public Neighborhood Neighborhood { get; set; }
        public List<Expertise> Expertises { get; set; }
        public List<Corporate> Corporates { get; set; }
    }
}
