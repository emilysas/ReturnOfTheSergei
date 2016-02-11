using System.Net.Http;

namespace StarWarsCode
{
    public class ApiCaller
    {
        public string GetFilmInfo()
        {
            var apiPath = "http://swapi.co/api/films/1";
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(apiPath).Result;
            var filmInfo = response.Content.ReadAsStringAsync().Result;
            
            return filmInfo;
        }
    }
}
