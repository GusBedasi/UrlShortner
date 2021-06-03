namespace UrlShortner.Database
{
    public class MongoDbConfig
    {
        public string DatabaseName { get; set; }
        public string UrlsCollectionName{ get; set; }
        public string ConnectionString { get; set; }
    }
}
