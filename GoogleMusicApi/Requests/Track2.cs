using GoogleMusicApi.Structure;
using Newtonsoft.Json;

namespace GoogleMusicApi.Requests
{
    [JsonObject]
    public class Track2
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("creationTimestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("lastModifiedTimestamp")]
        public string LastModifiedTimestamp { get; set; }

        [JsonProperty("recentTimestamp")]
        public string RecentTimestamp { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("composer")]
        public string Composer { get; set; }

        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("albumArtist")]
        public string AlbumArtist { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("trackNumber")]
        public int TrackNumber { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("durationMillis")]
        public long DurationMillis { get; set; }

        [JsonProperty("beatsPerMinute")]
        public int BeatsPerMinute { get; set; }

        [JsonProperty("albumArtRef")]
        public ArtReference[] AlbumArtRef { get; set; }

        [JsonProperty("playCount")]
        public int PlayCount { get; set; }

        [JsonProperty("totalTrackCount")]
        public int TotalTrackCount { get; set; }

        [JsonProperty("discNumber")]
        public int DiscNumber { get; set; }

        [JsonProperty("totalDiscCount")]
        public int TotalDiscCount { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("estimatedSize")]
        public long EstimatedSize { get; set; }

        [JsonProperty("albumId")]
        public string AlbumId { get; set; }

        [JsonProperty("artistId")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("nid")]
        public string NId { get; set; }

        [JsonProperty("artistArtRef")]
        public ArtReference[] ArtistArtRef { get; set; }

        [JsonProperty("storeId")]
        public string StoreId { get; set; }

        [JsonProperty("primaryVideo")]
        public Video PrimaryVideo { get; set; }

        [JsonProperty("lastRatingChangeTimestamp")]
        public string LastRatingChangeTimestamp { get; set; }
    }
}