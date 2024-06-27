using Newtonsoft.Json;

namespace Netflix.Solution.Controllers.Areas.Netflix.Models.Common
{
    public class CommonResponse<T>
    {
        [JsonProperty("result")]
        public required string Result { get; set; }
        [JsonProperty("errorCode")]
        public required string ErrorCode { get; set; }
        [JsonProperty("errorMessage")]
        public required string ErrorMessage { get; set; }
        [JsonProperty("data")]
        public required T Data { get; set; }
    }
}
