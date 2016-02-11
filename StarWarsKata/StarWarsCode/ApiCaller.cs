using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace StarWarsCode
{
    public class ApiCaller
    {
        public FilmInfo GetFilmInfo()
        {
            var apiPath = "http://swapi.co/api/films/1";
            var client = new WebClient();
            var json = client.DownloadString(apiPath);
            var filmInfo = JsonConvert.DeserializeObject<FilmInfo>(json);
            return filmInfo;
        }

        public string GetOpeningCrawl()
        {
            var filmInfo = GetFilmInfo();
            return filmInfo.opening_crawl;
        }
    }
}
