using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class RasaDoamin
    {
        public string Path { get; set; }
        public bool StoreEntitiesAsSlots { get; set; } = true;

        public virtual ICollection<DomainAction> DomainActions { get; set; }
        public virtual ICollection<DomainEntity> DomainEntities { get; set; }
        public virtual ICollection<DomainIntent> DomainIntents { get; set; }
        public virtual ICollection<DomainSlot> DomainSlots { get; set; }
        public virtual ICollection<DomainTemplate> DomainTemplates { get; set; }
    }
}
