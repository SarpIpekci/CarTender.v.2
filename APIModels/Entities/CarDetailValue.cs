using System;
using System.Collections.Generic;

namespace APIModels.Entities
{
    public class CarDetailValue : BaseEntity
    {
        public string CarDetailValueName { get; set; }
        public Guid CarDetailID { get; set; }
        public CarDetail CarDetail { get; set; }
        public List<CarValue> CarValue { get; set; }

    }
}
