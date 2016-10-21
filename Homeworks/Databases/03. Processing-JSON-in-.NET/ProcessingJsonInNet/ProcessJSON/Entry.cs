using System;
using Newtonsoft.Json;

namespace ProcessJSON
{
    public class Entry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("published")]
        public DateTime Published { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("media:group")]
        public MediaGroup MediaGroup { get; set; }
    }
}
