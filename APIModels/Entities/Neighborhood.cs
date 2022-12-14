using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Neighborhood : BaseEntity
    {
        public Guid DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }
        public string NeighborhoodName { get; set; }
    }
}
