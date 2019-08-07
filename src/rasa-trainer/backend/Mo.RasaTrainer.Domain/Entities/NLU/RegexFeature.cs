using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.NLU
{
    /// <summary>
    /// 正则表达式特征
    /// </summary>
    public class RegexFeature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string Filename { get; set; }
    }
}
