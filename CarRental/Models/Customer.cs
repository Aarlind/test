using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName ="varchar(100)")]
        public string CustomerName { get; set; }

    }
}
