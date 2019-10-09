using Newtonsoft.Json;

namespace TorrentAPI
{
    public class TorrentResults
    {
        [JsonProperty("torrent_results")]
        public Torrent[] Torrents { get; set; }
        public string Error { get; set; }
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }
    }
}
