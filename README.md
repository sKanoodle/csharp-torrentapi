# csharp-torrentapi
C# wrapper for rarbg torrentapi

## original api definition
https://torrentapi.org/apidocs_v2.txt?app_id=123

## example usage
``` cs
var client = new RarbgApiClient("https://torrentapi.org/pubapi_v2.php", "my_App_ID");
var settings = new Settings()
{
    Limit = 100,
    Mode = Mode.SearchString,
    Filters = new[] { Filter.MoviesFullBD },
    Search = "Harry Potter",
};
var result = await client.GetResponseAsync(settings);
foreach (var torrent in result.Torrents)
    Console.WriteLine(torrent.Download);
```