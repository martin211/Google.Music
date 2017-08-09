using GoogleMusicApi.Sessions;
using GoogleMusicApi.Structure;
using Newtonsoft.Json;

namespace GoogleMusicApi.Requests.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RecordRequest : PostRequest
    {
        [JsonProperty("clientTimeMillis")]
        public string ClientTimeMillis { get; set; }

        [JsonProperty("events")]
        public Event[] Events { get; set; }

        public RecordRequest(Session session) : base(session)
        {
        }
    }
}