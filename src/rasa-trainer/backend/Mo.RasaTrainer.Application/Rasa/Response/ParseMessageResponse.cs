using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Application.Rasa.Response
{
    public class ParseMessageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<EntitiesItem> Entities { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Intent Intent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "intent_ranking")]
        public List<IntentRankingItem> IntentRanking { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }
    }

    public class EntitiesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int Start { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int End { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Entity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Confidence { get; set; }
    }

    public class Intent
    {
        /// <summary>
        /// 
        /// </summary>
        public double Confidence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }

    public class IntentRankingItem
    {
        /// <summary>
        /// 
        /// </summary>
        public double Confidence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
