using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class GetResponseModel
    {
        [JsonPropertyName("content")]
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}