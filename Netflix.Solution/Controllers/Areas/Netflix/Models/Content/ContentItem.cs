using Newtonsoft.Json;

namespace Netflix.Solution.Controllers.Areas.Netflix.Models.Content
{
    public class ContentItem
    {
        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;
        [JsonProperty("category")]
        public string Category { get; set; } = string.Empty;
        [JsonProperty("title")]

        public string Title { get; set; } = string.Empty;
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
        [JsonProperty("limitAge")]
        public int LimitAge { get; set; } = 0;
        [JsonProperty("genre")]
        public string Genre { get; set; } = string.Empty;
        [JsonProperty("mainImg")]
        public string MainImg { get; set; } = string.Empty;
        [JsonProperty("summaryImg")]
        public string SummaryImg { get; set; } = string.Empty;
        [JsonProperty("isTop")]
        public bool IsTop { get; set; } = false;
        [JsonProperty("isRecommend")]
        public bool IsRecommend { get; set; } = false;
    }
}
