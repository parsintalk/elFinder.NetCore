using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models
{
    public class RootModel : DirectoryModel
    {
        [JsonPropertyName("isroot")]
        [JsonProperty("isroot")]
        public byte IsRoot => 1;
    }
}