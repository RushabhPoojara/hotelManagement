using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Demo_Asp_DotNetCoreWebAPI;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext()
    {
    }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public DbSet<LocalUser> LocalUsers { get; set; }

    public DbSet<Villa> Villas { get; set; }

    public DbSet<VillaNumber> VillaNumbers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = "Royale Villa",
                Details = "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk",
                ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.UtcNow
            },
            new Villa()
            {
                Id = 2,
                Name = "Premium Pool Villa",
                Details = "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk",
                ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                Occupancy = 4,
                Rate = 300,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.UtcNow
            },
            new Villa()
            {
                Id = 3,
                Name = "Luxury Pool Villa",
                Details = "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk",
                ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                Occupancy = 4,
                Rate = 400,
                Sqft = 750,
                Amenity = "",
                CreatedDate = DateTime.UtcNow
            },
            new Villa()
            {
                Id = 4,
                Name = "Diamond Villa",
                Details = "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk",
                ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                Occupancy = 4,
                Rate = 550,
                Sqft = 900,
                Amenity = "",
                CreatedDate = DateTime.UtcNow
            },
            new Villa()
            {
                Id = 5,
                Name = "Diamond Pool Villa",
                Details = "Fmaspef ;xvsdpf pvbfpjgm mpgkpdfkbcp pfbvdfp pgkdpbk",
                ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                Occupancy = 4,
                Rate = 600,
                Sqft = 1100,
                Amenity = "",
                CreatedDate = DateTime.UtcNow
            }
        );
    }
}
