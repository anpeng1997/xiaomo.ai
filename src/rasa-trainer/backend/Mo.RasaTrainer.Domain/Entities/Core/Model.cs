using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class Model
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime TrainedAt { get; set; }
    }
}
