using Newtonsoft.Json;

namespace Netflix.Solution.Controllers.Areas.Netflix.Models.Account
{
    public class LoginParameter
    {
        [JsonProperty("uid")]
        public required string Uid { get; set; }
        [JsonProperty("password")]
        public required string Password { get; set; }
    }
}
