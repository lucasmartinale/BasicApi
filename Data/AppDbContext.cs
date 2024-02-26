using BasicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Photos> Photos { get; set; }
    }
}
