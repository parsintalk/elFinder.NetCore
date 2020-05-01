using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class RemoveResponseModel
    {
        public RemoveResponseModel()
        {
            Removed = new List<string>();
        }

        [JsonPropertyName("removed")]
        [JsonProperty("removed")]
        public List<string> Removed { get; }
    }
}