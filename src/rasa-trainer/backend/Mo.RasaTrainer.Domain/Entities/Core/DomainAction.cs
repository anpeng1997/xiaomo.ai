using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class DomainAction
    {
        public int ActionId { get; set; }
        public string Action { get; set; }
        public bool IsForm { get; set; } = false;

        public RasaDoamin Domain { get; set; }
    }
}
