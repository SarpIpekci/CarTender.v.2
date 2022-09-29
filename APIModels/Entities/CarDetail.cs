using System.Collections.Generic;

namespace APIModels.Entities
{
    public class CarDetail : BaseEntity
    {
        public string CarDetailName { get; set; }
        public List<CarDetailValue> DetailValues { get; set; }
    }
}
