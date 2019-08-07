using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.NLU
{
    public class TrainingDataEntity
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string Value { get; set; }
        public int? Start { get; set; }
        public int? End { get; set; }
        public string Extractor { get; set; }

        public TrainingData TrainingData { get; set; }
    }
}
