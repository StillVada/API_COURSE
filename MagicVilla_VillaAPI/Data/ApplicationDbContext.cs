using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "name",
                    Details = "goy",
                    ImageUrl = "",
                    Occupancy =5, 
                    Rate = 200,
                    Sqft = 550, 
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 1, 1)
                },
                new Villa()
                {
                    Id = 2,
                    Name = "name",
                    Details = "goy",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 1, 1)
                }
                
                );
                
        }
    }
}
