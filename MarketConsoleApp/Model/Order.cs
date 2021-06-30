using System;
using System.Collections.Generic;
using System.Text;

namespace MarketConsoleApp.Model
{
    class Order
    {
        public int OrderNo;
        public static int OrderNoCount { get; set; }
        public double Cost { get; set; }
        public string Date { get; set; }
        public List<OrderItem> SoldProducts { get; set; }
        public Order(byte day , byte mounth,int year, List<OrderItem> soldProducts)
        {
            Date = day.ToString() + " " + mounth.ToString() + " " + year.ToString();
            OrderNoCount++;
            OrderNo = OrderNoCount;
            SoldProducts = new List<OrderItem>();
                
        }

    }
}
