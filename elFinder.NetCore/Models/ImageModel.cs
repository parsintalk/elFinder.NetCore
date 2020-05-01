using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models
{
    internal class ImageModel : FileModel
    {
        [JsonPropertyName("tmb")]
        [JsonProperty("tmb")]
        public object Thumbnail { get; set; }

        [JsonPropertyName("dim")]
        [JsonProperty("dim")]
        public string Dimension { get; set; }
    }
}