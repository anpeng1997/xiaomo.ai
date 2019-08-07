using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mo.RasaTrainer.Application.Rasa.Request
{
    public class ReplaceCurrentlyLoadedModelRequest
    {
        [JsonProperty(PropertyName = "model_file")]
        public string ModelFile { get; set; }

        [JsonProperty(PropertyName = "model_server")]
        public ModelServer ModelServer { get; set; }

        /// <summary>
        /// Enum: "aws" "gcs" "azure"
        /// </summary>
        [JsonProperty(PropertyName = "remote_storage")]
        public string RemoteStorage { get; set; }
    }

    public class ModelServer
    {
        public string Url { get; set; }
        public object Params { get; set; }
        public object Headers { get; set; }
        [JsonProperty(PropertyName = "basic_auth")]
        public object BasicAuth { get; set; }
        [JsonProperty(PropertyName = "wait_time_between_pulls")]
        public int WatiTimeBetweenPulls { get; set; } = 0;
    }
}
