using System.Net;

namespace ProductAPI.Utilities
{
    public class ResponseMessage
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
    }
}
