using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class SizeResponseModel
    {
        [JsonPropertyName("size")]
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonPropertyName("fileCnt")]
        [JsonProperty("fileCnt")]
        public int FileCount { get; set; }

        [JsonPropertyName("dirCnt")]
        [JsonProperty("dirCnt")]
        public int DirectoryCount { get; set; }
    }
}