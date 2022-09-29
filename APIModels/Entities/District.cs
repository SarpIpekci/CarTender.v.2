﻿using System.ComponentModel.DataAnnotations.Schema;

namespace APIModels.Entities
{
    public class District : BaseEntity
    {
        public int TownID { get; set; }
        [ForeignKey("TownID")]
        public Town Town { get; set; }
        public string DistrictName { get; set; }
    }
}
