using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class DomainTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public string AnnotatorId { get; set; }
        public DateTime AnnotatorAt { get; set; }

        public RasaDoamin Domain { get; set; }
    }
}
