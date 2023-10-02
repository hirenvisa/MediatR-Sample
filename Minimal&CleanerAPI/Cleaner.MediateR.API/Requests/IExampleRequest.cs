using Cleaner.MediateR.API.Services;

namespace Cleaner.MediateR.API.Requests
{
    public class IExampleRequest: IHttpRequest
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public GuidService GuidService { get; set; }
    }
}
