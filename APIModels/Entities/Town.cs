using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class Town : BaseEntity
    {
        public Guid CityID { get; set; }
        [ForeignKey("CityID")]
        public City City { get; set; }
        public string TownName { get; set; }
    }
}
