using GoogleMusicApi.Requests.Data;

namespace GoogleMusicApi.Requests
{
    /// <summary>
    /// Record activity request.
    /// </summary>
    /// <seealso cref="GoogleMusicApi.StructuredRequest{GoogleMusicApi.Requests.Data.RecordRequest, GoogleMusicApi.Requests.Data.RecordResponse}" />
    public class RecordRequest : StructuredRequest<Data.RecordRequest, RecordResponse>
    {
        public override string RelativeRequestUrl => "activity/record";
    }
}