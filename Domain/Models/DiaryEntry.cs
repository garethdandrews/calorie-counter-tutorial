using System; 
using System.Collections.Generic; 
 
namespace calorie_counter_tutorial.Domain.Models 
{ 
    public class DiaryEntry 
    { 
        public int Id { get; set; } 
        public DateTime Date { get; set; } 
        public int TotalCalories { get; set; } 
        public int CalorieTarget { get; set; } 
 
        public IList<FoodItem> FoodItems { get; set; } 
    } 
} 