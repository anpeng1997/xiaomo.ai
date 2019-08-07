using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Application.Rasa.Request
{
    public class ParseMessageRequest
    {
        [JsonProperty(PropertyName ="message_id")]
        public string MessageId { get; set; }
        public string Text { get; set; }
    }
}
