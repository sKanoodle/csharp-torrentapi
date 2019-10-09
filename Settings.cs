using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TorrentAPI
{
    public class Settings
    {
        public Mode Mode = Mode.None;
        public string Search;
        public Filter[] Filters;
        public int Limit;
        public Sort Sort;
        public int MinSeeders;
        public int MinLeechers;
        public bool GetUnranked;

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();


            result.Append(GetModeString());

            if (Filters?.Any() ?? false)
                result.Append("&category=" + String.Join(';', Filters.Cast<int>()));

            if (MinSeeders > 0)
                result.Append($"&min_seeders={MinSeeders}");

            if (MinLeechers > 0)
                result.Append($"&min_leechers={MinLeechers}");

            if (Limit > 0 && Limit < 101)
                result.Append($"&limit={Limit}");

            result.Append("&format=json_extended");
            result.Append(GetSortString());

            if (GetUnranked)
                result.Append("&ranked=0");


            return result.ToString();
        }

        private string GetModeString()
        {
            switch (Mode)
            {
                case Mode.None:
                    throw new Exception("no mode specified");
                case Mode.List:
                    return "mode=list";
                case Mode.SearchString:
                    return $"mode=search&search_string={Search}";
                case Mode.SearchImdb:
                    return $"mode=search&search_imdb={Search}";
                case Mode.SearchTvdb:
                    return $"mode=search&search_tvdb={Search}";
                case Mode.SearchThemoviedb:
                    return $"mode=search&search_themoviedb={Search}";
                default:
                    throw new NotImplementedException();
            }
        }

        private string GetSortString()
        {
            switch (Sort)
            {
                case Sort.Default:
                    return String.Empty;
                case Sort.Seeders:
                    return "&sort=seeders";
                case Sort.Leechers:
                    return "&sort=leechers";
                case Sort.Last:
                    return "&sort=last";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
