using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Domain.Entities.NLU
{
    /// <summary>
    /// 查找表
    /// </summary>
    public class LookupTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Elements { get; set; }
        public string Filename { get; set; }
    }
}
