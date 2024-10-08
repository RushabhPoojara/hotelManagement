using System.Linq.Expressions;

namespace Demo_Asp_DotNetCoreWebAPI;

public interface IVillaNumberRepository : IRepository<VillaNumber>
{
    Task<VillaNumber> UpdateAsync(VillaNumber entity);
}
