using ByteBuzz.Models;
using Microsoft.EntityFrameworkCore;

namespace ByteBuzz.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }

        public DbSet<Post> Posts {  get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Health" },
                new Category { Id = 3, Name = "LifeStyle" }

                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Tech Post 1",
                    Content = "Content of Tech Post 1",
                    Author = "Mohammad Arsalan",
                    PublishedDate = new DateTime(2023, 1, 1), // Static date instead of DateTime.Now
                    CategoryId = 1,
                    FeatureImagePath = "tech_image.jpg", // Sample image path
                },
                new Post
                {
                    Id = 2,
                    Title = "Health Post 1",
                    Content = "Content of Health Post 1",
                    Author = "Shaikh Safwan ",
                    PublishedDate = new DateTime(2023, 1, 1), // Static date
                    CategoryId = 2,
                    FeatureImagePath = "health_image.jpg", // Sample image path
                },
                new Post
                {
                    Id = 3,
                    Title = "Lifestyle Post 1",
                    Content = "Content of Lifestyle Post 1",
                    Author = "Khan Junaid",
                    PublishedDate = new DateTime(2023, 1, 1), // Static date
                    CategoryId = 3,
                    FeatureImagePath = "lifestyle_image.jpg", // Sample image path
                }
                );

        }


    }
}
