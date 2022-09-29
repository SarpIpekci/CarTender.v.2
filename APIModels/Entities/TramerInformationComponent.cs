using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class TramerInformationComponent : BaseEntity
    {
        [Key, Column(Order = 0)]
        public int TramerComponentID { get; set; }
        public TramerComponent TramerComponent { get; set; }

        [Key, Column(Order = 1)]
        public int TramerInformationID { get; set; }
        public TramerInformation TramerInformation { get; set; }
    }
}
