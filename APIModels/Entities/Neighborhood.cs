using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Neighborhood : BaseEntity
    {
        public int DistrictID { get; set; }
        [ForeignKey("DistrictID")]
        public District District { get; set; }
        public string NeighborhoodName { get; set; }
    }
}
