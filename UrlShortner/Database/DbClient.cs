using Microsoft.Extensions.Options;
using MongoDB.Driver;
using UrlShortner.Models.Entities;

namespace UrlShortner.Database
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Url> _urls;
        public DbClient(IOptions<MongoDbConfig> mongoDbConfig)
        {
            var client = new MongoClient(mongoDbConfig.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbConfig.Value.DatabaseName);
            _urls = database.GetCollection<Url>(mongoDbConfig.Value.UrlsCollectionName);
        }
        public IMongoCollection<Url> GetUrlCollection() => _urls;
    }
}
