using GoogleMusicApi.Requests.Data;
using GoogleMusicApi.Structure;

namespace GoogleMusicApi.Requests
{
    public class ListTrackFeed2 : StructuredRequest<ResultListRequest, ResultList<Track2>>
    {
        public override string RelativeRequestUrl => "trackfeed";
    }
}