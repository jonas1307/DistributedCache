using System.Text.Json.Serialization;

namespace DistributedCache.WebApi.Models.Responses
{
    public class BaseResponse
    {
        [JsonIgnore]
        public int StatusCode { get; set; } = 200;

        public string? Message { get; set; }
    }
}
