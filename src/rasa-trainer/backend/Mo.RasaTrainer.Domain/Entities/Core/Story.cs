using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.Core
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StoryContent { get; set; }
        public string User { get; set; }
        public DateTime AnnotatedAt { get; set; }
        public string Filename { get; set; }
    }
}
