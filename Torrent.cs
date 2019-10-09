using Newtonsoft.Json;

namespace TorrentAPI
{
    public class Torrent
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Download { get; set; }
        public int Seeders { get; set; }
        public int Leechers { get; set; }
        public long Size { get; set; }
        public string PUpdate { get; set; }
        [JsonProperty("episode_info")]
        public EpisodeInfo EpisodeInfo { get; set; }
        public int Ranked { get; set; }
        [JsonProperty("info_page")]
        public string InfoPage { get; set; }
    }
}
