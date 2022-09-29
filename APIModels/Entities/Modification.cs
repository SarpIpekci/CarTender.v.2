using System.Collections.Generic;

namespace APIModels.Entities
{
    public class Modification : BaseEntity
    {
        public string ModificationComponentName { get; set; }
        public List<CarModification> CarModifications { get; set; }

    }
}
