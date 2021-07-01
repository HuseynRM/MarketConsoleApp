using MarketConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketConsoleApp.Model
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Catagories Catagory { get; set; }
        public int Count { get; set; }

        private static int  CodeCount { get; set; } = 1000;

        public string Code;

        public Product(string name, double price, Catagories catagory, int count)
        {
            CodeCount++;
            Name = name;
            Price = price;
            Catagory = catagory;
            Count = count;
            Code = name.Trim().ToUpper().Substring(0, 2) + CodeCount.ToString();

        }
        public override string ToString()
        {
            return $"{Code} {Name} {Price} {Catagory} {Count}";
        }
    }
}
