﻿namespace HandmadeMarket.Models
{
    public class OrderItem
    {
       //[Key]
        public int OrderItemId { get; set; } // Part of composite PK
        [ForeignKey("Order")]
        public int OrderId { get; set; }    // Part of composite PK
      
        public int Quantity { get; set; }
        public decimal Price { get; set; }
       
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public Order Order { get; set; }

    }
}
