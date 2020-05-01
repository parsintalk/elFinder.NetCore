using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models
{
    public class FileModel : BaseModel
    {
        /// <summary>
        ///  Hash of parent directory. Required except roots dirs.
        /// </summary>
        [JsonPropertyName("phash")]
        [JsonProperty("phash")]
        public string ParentHash { get; set; }
    }
}