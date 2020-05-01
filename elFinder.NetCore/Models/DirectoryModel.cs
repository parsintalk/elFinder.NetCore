using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models
{
    public class DirectoryModel : BaseModel
    {
        /// <summary>
        ///  Indicates the volume Id.
        /// </summary>
        //[JsonPropertyName("volumeId")]
        [JsonPropertyName("volumeid")]
        [JsonProperty("volumeid")] // https://github.com/Studio-42/elFinder/issues/2403
        public string VolumeId { get; set; }

        /// <summary>
        ///  Hash of parent directory. Required except roots dirs.
        /// </summary>
        [JsonPropertyName("phash")]
        [JsonProperty("phash")]
        public string ParentHash { get; set; }

        /// <summary>
        /// Is directory contains subfolders
        /// </summary>
        [JsonPropertyName("dirs")]
        [JsonProperty("dirs")]
        public byte Dirs { get; set; }
    }
}