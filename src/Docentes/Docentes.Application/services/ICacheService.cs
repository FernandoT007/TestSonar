namespace Docentes.Application.services;

public interface ICacheService
{
    Task<T?> GetCacheValueAsync<T>(string key);

    Task SetCacheValueAsync<T>(string key, T value, TimeSpan? expirationTime = null );
}