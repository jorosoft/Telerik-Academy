using Newtonsoft.Json;

namespace ProcessJSON
{
    public class MediaGroup
    {
        [JsonProperty("media:description")]
        public string MediaDescription { get; set; }

        [JsonProperty("media:content")]
        public MediaContent MediaContent { get; set; }
    }
}
