using GoogleMusicApi.Requests.Data;
using GoogleMusicApi.Structure;

namespace GoogleMusicApi.Requests
{
    public class ListDevices : StructuredRequest<ListDevicesRequest, ResultList<Device>>
    {
        public override string RelativeRequestUrl => "devicemanagementinfo";
    }
}