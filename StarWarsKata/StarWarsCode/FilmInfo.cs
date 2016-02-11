namespace StarWarsCode
{
    public class FilmInfo
    {
        private string _openingCrawl;

        public string opening_crawl
        {
            get { return _openingCrawl.Replace("Jedi", "Meerkat"); }
            set { _openingCrawl = value; }
        }
    }
}
