using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class DomainIntent
    {
        public int IntentId { get; set; }
        public string Intent { get; set; }
        public bool UseEntities { get; set; }
        public string IgnoreEntities { get; set; }

        public RasaDoamin Domain { get; set; }
    }
}
