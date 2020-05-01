using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace elFinder.NetCore.Models.Commands
{
    public class Archive
    {
        [JsonPropertyName("create")]
        [JsonProperty("create")]
        public IEnumerable<string> Create { get; set; }

        [JsonPropertyName("extract")]
        [JsonProperty("extract")]
        public IEnumerable<string> Extract { get; set; }

        [JsonPropertyName("createext")]
        [JsonProperty("createext")]
        public IDictionary<string, string> CreateExt { get; set; }
    }

    public class Options
    {
        private static string[] disabled = new string[] { "callback", "chmod", "editor", "netmount", "ping", "search", "zipdl" };
        private static string[] empty = new string[0];
        private static Archive emptyArchives = new Archive();

        public Options(FullPath fullPath)
        {
            Path = fullPath.RootVolume.Alias;
            if (fullPath.RelativePath != string.Empty)
            {
                Path += Separator + fullPath.RelativePath.Replace('\\', Separator);
            }
            Url = fullPath.RootVolume.Url ?? string.Empty;
            ThumbnailsUrl = fullPath.RootVolume.ThumbnailUrl ?? string.Empty;
            //ThumbnailsUrl = fullPath.Root.ThumbnailUrl ?? fullPath.Root.Url + "/.tmb/";
            Archivers = new Archive
            {
                Create = new[] { "application/zip" },
                Extract = new[] { "application/zip" },
                CreateExt = new Dictionary<string, string>
                {
                    {"application/zip" ,"zip"}
                }
            };
        }

        [JsonPropertyName("archivers")]
        [JsonProperty("archivers")]
        public Archive Archivers { get; set; }

        [JsonPropertyName("disabled")]
        [JsonProperty("disabled")]
        public IEnumerable<string> Disabled => disabled;

        [JsonPropertyName("copyOverwrite")]
        [JsonProperty("copyOverwrite")]
        public byte IsCopyOverwrite => 1;

        [JsonPropertyName("path")]
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonPropertyName("separator")]
        [JsonProperty("separator")]
        public char Separator => '/';

        [JsonPropertyName("tmbUrl")]
        [JsonProperty("tmbUrl")]
        public string ThumbnailsUrl { get; set; }

        [JsonPropertyName("trashHash")]
        [JsonProperty("trashHash")]
        public string TrashHash => string.Empty;

        [JsonPropertyName("uploadMaxConn")]
        [JsonProperty("uploadMaxConn")]
        public int UploadMaxConnections => -1;

        [JsonPropertyName("uploadMaxSize")]
        [JsonProperty("uploadMaxSize")]
        public string UploadMaxSize { get; set; }

        [JsonPropertyName("url")]
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}