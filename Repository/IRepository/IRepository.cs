using System.Linq.Expressions;

namespace Demo_Asp_DotNetCoreWebAPI;

public interface IRepository<T> where T : class
{
    Task CreateAsync(T entity);

    Task RemoveAsync(T entity);

    Task SaveAsync();

    Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, int pageSize = 0, int pageNumber = 1);

    Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null);
}
