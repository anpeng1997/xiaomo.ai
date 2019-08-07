using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class DomainSlot
    {
        public int SlotId { get; set; }
        public string Slot { get; set; }
        public bool AutoFill { get; set; } = true;
        public string Type { get; set; }
        public string Values { get; set; }
        public string InitialValue { get; set; }

        public RasaDoamin Domain { get; set; }
    }
}
