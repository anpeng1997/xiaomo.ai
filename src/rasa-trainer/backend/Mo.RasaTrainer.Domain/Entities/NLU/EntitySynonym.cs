using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.NLU
{
    /// <summary>
    /// 实体同义词
    /// </summary>
    public class EntitySynonym
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Synonym { get; set; }
        public string Filename { get; set; }
    }
}
