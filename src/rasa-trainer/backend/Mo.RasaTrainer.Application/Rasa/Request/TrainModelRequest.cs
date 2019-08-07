using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Application.Rasa.Request
{
    public class TrainModelRequest
    {
        /// <summary>
        /// Rasa domain in plain text
        /// </summary>
        public string Domain { get; set; }
        /// <summary>
        /// [Required] Rasa config in plain text
        /// </summary>
        public string Config { get; set; }
        /// <summary>
        /// Rasa NLU training data in markdown format
        /// </summary>
        public string Nlu { get; set; }
        /// <summary>
        /// Rasa Core stories in markdown format
        /// </summary>
        public string Stories { get; set; }
        /// <summary>
        /// Output directory
        /// </summary>
        public string Out { get; set; }
        /// <summary>
        /// Force a model training even if the data has not changed
        /// </summary>
        public string Force { get; set; }
    }
}
