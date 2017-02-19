using GoogleMusicApi.Sessions;

namespace GoogleMusicApi.Requests.Data
{
    public class ListDevicesRequest : GetRequest
    {
        public ListDevicesRequest(Session session) : base(session)
        {
        }
    }
}