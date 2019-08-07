using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mo.RasaTrainer.Application.Rasa.Request;
using Mo.RasaTrainer.Application.Rasa.Response;

namespace Mo.RasaTrainer.Application.Rasa
{
    public class RasaHttpRequest : IRasaHttpRequest
    {
        private readonly HttpClient _http;
        public RasaHttpRequest(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("http://10.0.1.41:5005");
        }

        public Task<EvaluateStoriesResponse> EvaluateStoriesAsync(string data, bool e2e = false)
        {
            throw new NotImplementedException();
        }

        public Task<RasaCurrentlyLoadedModelResponse> GetRasaCurrentlyLoadedModelInfoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RasaVersionResponse> GetRasaVersionAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> HealthCheckAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ParseMessageResponse> ParseMessageAsync(ParseMessageRequest request, string emulation_mode)
        {
            throw new NotImplementedException();
        }

        public Task ReplaceCurrentlyLoadedModelAsync(ReplaceCurrentlyLoadedModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<TrainModelResponse> TrainModelAsync(TrainModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
