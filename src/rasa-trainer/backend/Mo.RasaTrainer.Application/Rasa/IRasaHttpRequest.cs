using Mo.RasaTrainer.Application.Rasa.Request;
using Mo.RasaTrainer.Application.Rasa.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mo.RasaTrainer.Application.Rasa
{
    public interface IRasaHttpRequest
    {
        #region Server Information
        Task<bool> HealthCheckAsync();
        Task<RasaVersionResponse> GetRasaVersionAsync();
        Task<RasaCurrentlyLoadedModelResponse> GetRasaCurrentlyLoadedModelInfoAsync();
        #endregion

        #region Model
        Task<TrainModelResponse> TrainModelAsync(TrainModelRequest request);
        Task<EvaluateStoriesResponse> EvaluateStoriesAsync(string data, bool e2e = false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emulation_mode">Enum: "WIT" "LUIS" "DIALOGFLOW"</param>
        /// <returns></returns>
        Task<ParseMessageResponse> ParseMessageAsync(ParseMessageRequest request, string emulation_mode);
        Task ReplaceCurrentlyLoadedModelAsync(ReplaceCurrentlyLoadedModelRequest request); 
        #endregion
    }
}
