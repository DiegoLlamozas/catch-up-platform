using CatchUpPlatform.API.News.Domain.Model.Aggregates;

namespace CatchUpPlatform.API.News.Domain.Repositories;

public interface IFavoriteSourceRepository
{
    Task<IEnumerable<FavoriteSource>> FindByNewsApiKeyAsync(string newsApiKey);
    
    Task<FavoriteSource?> FindByIdAsync(int id);
    
    
}