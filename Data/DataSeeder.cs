using Microsoft.EntityFrameworkCore;
using OneDoc.Api.Data;
using OneDoc.Api.Models;

namespace OneDoc.Api.Data
{
    public static class DatabaseSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            // Apply any pending migrations
            await context.Database.MigrateAsync();

            // If there are already files, don’t seed again
            if (await context.Files.AnyAsync())
                return;

            var initialFiles = new[]
            {
                new FileDetails
                {
                    FileName = "Welcome.pdf",
                    FilePath = "/files/Welcome.pdf",
                    FileType = "pdf",
                    FileSize = 1024 * 50,
                    DateCreated = DateTime.UtcNow,
                    LastModified = DateTime.UtcNow,
                    FileOwner = "System",
                    IsFavorite = true
                },
                new FileDetails
                {
                    FileName = "UserGuide.docx",
                    FilePath = "/files/UserGuide.docx",
                    FileType = "docx",
                    FileSize = 1024 * 200,
                    DateCreated = DateTime.UtcNow.AddDays(-1),
                    LastModified = DateTime.UtcNow.AddDays(-1),
                    FileOwner = "System",
                    IsFavorite = false
                },
                // add more demo entries as you like...
            };

            context.Files.AddRange(initialFiles);
            await context.SaveChangesAsync();
        }
    }
}
