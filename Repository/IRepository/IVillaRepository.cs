using System.Linq.Expressions;

namespace Demo_Asp_DotNetCoreWebAPI;

public interface IVillaRepository : IRepository<Villa>
{
    Task<Villa> UpdateAsync(Villa entity);
}
