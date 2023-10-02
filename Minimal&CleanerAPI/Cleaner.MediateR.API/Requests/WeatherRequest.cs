namespace Cleaner.MediateR.API.Requests
{
    public class WeatherRequest: IHttpRequest
    {
        public string City { get; set; }
        public int Days { get; set; }
    }
}
