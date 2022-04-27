using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string PMethod   { get; set; }
        public decimal GTotal { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
