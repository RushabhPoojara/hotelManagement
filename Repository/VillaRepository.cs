using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Demo_Asp_DotNetCoreWebAPI;

public class VillaRepository : Repository<Villa>, IVillaRepository
{ 
    private readonly ApplicationDbContext _db;

    public VillaRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task<Villa> UpdateAsync(Villa entity)
    {
        entity.UpdatedDate = DateTime.UtcNow;
        _db.Villas.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }
}
