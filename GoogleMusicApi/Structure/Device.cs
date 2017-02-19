using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GoogleMusicApi.Structure
{
    [JsonObject]
    public class Device
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastAccessedTimeMs")]
        public string LastAccessedTimeMs { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DeviceType Type { get; set; }

        [JsonProperty("smartPhone")]
        public bool IsSmartPhone { get; set; }
    }

    public enum DeviceType
    {
        [EnumMember(Value = "DESKTOP_APP")]
        DesktopApp,

        [EnumMember(Value = "ANDROID")]
        Android,

        [EnumMember(Value = "IOS")]
        IOS
    }
}