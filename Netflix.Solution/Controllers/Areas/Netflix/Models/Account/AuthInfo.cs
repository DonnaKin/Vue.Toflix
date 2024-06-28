using Newtonsoft.Json;

namespace Netflix.Solution.Controllers.Areas.Netflix.Models.Account
{
    public class AuthInfo
    {
        [JsonProperty("uid")]
        public string Uid { get; set; } = string.Empty;
        [JsonProperty("password")]
        public string PassWord { get; set; } = string.Empty;
        [JsonProperty("birth")]
        public string Birth { get; set; } = string.Empty;
        [JsonProperty("favoriteList")]
        public IEnumerable<string> FavoriteList { get; set; } = Enumerable.Empty<string>();
        [JsonProperty("watchingList")]
        public IEnumerable<string> WatchingList { get; set; } = Enumerable.Empty<string>();
    }
}
