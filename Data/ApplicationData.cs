using Microsoft.EntityFrameworkCore;
using NewDiary.Models;


namespace NewDiary.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor accepting DbContextOptions and passing it to the base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet for DiaryEntryData
        public DbSet<DiaryEntryData> DiaryEntries { get; set; }

        // Configure the model and seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntryData>().HasData(
                new DiaryEntryData
                {
                    Id = 1,
                    Title = "Went to the Library",
                    Content = "Went to the library to read about Science and Chemistry",
                    CreatedDate = DateTime.Now 
                },
                new DiaryEntryData
                {
                    Id = 2,
                    Title = "Visited the Museum",
                    Content = "Had a great time exploring historical artifacts.",
                    CreatedDate = DateTime.Now.AddDays(-1) 
                }
            );
        }
    }
}
