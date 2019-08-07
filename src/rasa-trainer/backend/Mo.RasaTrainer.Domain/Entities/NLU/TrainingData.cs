using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.NLU
{
    public class TrainingData
    {
        public int Id { get; set; }
        public string Hash { get; set; }
        public string Text { get; set; }
        public string Intent { get; set; }
        public string AnnotatorId { get; set; }
        public DateTime AnnotatorAt { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<TrainingDataEntity> Entities { get; set; }
    }
}
