using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class InitResponseModel : BaseOpenResponseModel
    {
        private static string[] empty = new string[0];

        public InitResponseModel(DirectoryModel currentWorkingDirectory, Options options) : base(currentWorkingDirectory)
        {
            Options = options;
        }

        [JsonPropertyName("api")]
        [JsonProperty("api")]
        public string Api => "2.1";

        [JsonPropertyName("netDrivers")]
        [JsonProperty("netDrivers")]
        public IEnumerable<string> NetDrivers => empty;
    }
}