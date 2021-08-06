using calorie_counter_tutorial.Domain.Models; 
using Microsoft.EntityFrameworkCore; 
 
namespace calorie_counter_tutorial.Persistence.Contexts 
{ 
    public class ApplicationDbContext : DbContext 
    { 
        public DbSet<DiaryEntry> DiaryEntries { get; set; } 
        public DbSet<FoodItem> FoodItems { get; set; } 
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        } 
    } 
} 