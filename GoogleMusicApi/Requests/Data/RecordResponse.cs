using Newtonsoft.Json;

namespace GoogleMusicApi.Requests.Data
{
    public class RecordResponse
    {
        [JsonProperty("eventResults")]
        public EventResult[] EventResults { get; set; }
    }
}