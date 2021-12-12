using System.Net;

namespace Api.Entities.Results
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public HttpStatusCode Status { get; set; }
        public T? Data { get; set; }

        public Result()
        {
            Success = false;
            Message = "";
            Status = HttpStatusCode.OK;
        }

    }
}
