using Newtonsoft.Json;

namespace ProcessJSON
{
    public class MediaContent
    {
        [JsonProperty("@url")]
        public string Url { get; set; }
    }
}
