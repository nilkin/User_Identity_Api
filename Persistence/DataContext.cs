using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    //dotnet restore
    //dotnet ef migrations add IdentityAdded -p .\Persistence -s .\API
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<About> Abouts { get; set; }
    }
}
