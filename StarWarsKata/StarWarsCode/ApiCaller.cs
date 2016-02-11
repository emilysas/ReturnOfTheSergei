using System;
using System.Net;
using Newtonsoft.Json;

namespace StarWarsCode
{
    public class ApiCaller
    {
        public FilmInfo GetFilmInfo()
        {
            var apiPath = "http://swapi.co/api/films/" + RandomFilmSelector();
            var client = new WebClient();
            var json = client.DownloadString(apiPath);
            var filmInfo = JsonConvert.DeserializeObject<FilmInfo>(json);
            return filmInfo;
        }

        private string RandomFilmSelector()
        {
            var rnd = new Random();
            return rnd.Next(1, 7).ToString();
        }

        public string GetOpeningCrawl()
        {
            var filmInfo = GetFilmInfo();
            return filmInfo.opening_crawl;
        }
    }
}
