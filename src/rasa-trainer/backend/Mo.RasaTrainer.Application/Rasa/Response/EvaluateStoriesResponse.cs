using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Application.Rasa.Response
{
    public class EvaluateStoriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ActionsItem> Actions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "is_end_to_end_evaluation")]
        public string IsE2EEvaluation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Precision { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double F1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Accuracy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "in_training_data_fraction")]
        public double InTrainingDataFraction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Report { get; set; }
    }

    public class ActionsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Predicted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Policy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Confidence { get; set; }
    }
}
