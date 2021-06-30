using System;
using System.Collections.Generic;
using System.Text;

namespace MarketConsoleApp.Model
{
    class OrderItem
    {
        public int OrderItemNo;
        public int OrderCount { get; set; }
        public Product OrderProduct { get; set; }
        public OrderItem(int orderCount,Product orderProduct)
        { 
            OrderCount = orderCount;
            OrderProduct = orderProduct;
        }
    }
}
