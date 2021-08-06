namespace calorie_counter_tutorial.Domain.Models 
{ 
    public class FoodItem 
    { 
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int Calories { get; set; } 
 
        public DiaryEntry DiaryEntry { get; set; } 
    } 
} 