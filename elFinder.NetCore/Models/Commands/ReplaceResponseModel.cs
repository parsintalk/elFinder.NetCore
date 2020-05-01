using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class ReplaceResponseModel
    {
        public ReplaceResponseModel()
        {
            Added = new List<object>();
            Removed = new List<string>();
        }

        [JsonPropertyName("added")]
        [JsonProperty("added")]
        public List<object> Added { get; private set; }

        [JsonPropertyName("removed")]
        [JsonProperty("removed")]
        public List<string> Removed { get; private set; }
    }
}