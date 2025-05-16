using Microsoft.EntityFrameworkCore;
using OneDoc.Api.Models;

namespace OneDoc.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<FileDetails> Files { get; set; }
    }
}