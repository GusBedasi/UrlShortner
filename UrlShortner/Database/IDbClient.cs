using MongoDB.Driver;
using UrlShortner.Models.Entities;

namespace UrlShortner.Database
{
    public interface IDbClient
    {
        IMongoCollection<Url> GetUrlCollection();
    }
}
