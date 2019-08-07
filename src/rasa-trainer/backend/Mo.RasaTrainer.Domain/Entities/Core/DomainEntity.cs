using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class DomainEntity
    {
        public int EntityId { get; set; }
        public string Entity { get; set; }

        public RasaDoamin Domain { get; set; }
    }
}
