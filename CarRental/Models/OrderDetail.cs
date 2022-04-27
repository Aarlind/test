using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public long OrderMasterId { get; set; }
        public int FoodItemId { get; set; }
        public FoodItem FoodItem { get; set; }  
        public decimal FoodItemPrice { get; set; } 
        public int Quantity { get; set; }   
    }
}
