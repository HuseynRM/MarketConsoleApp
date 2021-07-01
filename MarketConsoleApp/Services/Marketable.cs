using MarketConsoleApp.Interfaces;
using MarketConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketConsoleApp.Services
{
    class Marketable : IMarketable
    {
        public List<Order> Orders { get ; set; }
        public List<Product> products { get ; set ; }
        public Marketable()
        {
            Orders = new List<Order>();
            products = new List<Product>();
        }

        public void Addorder(Order orders)
        {
            Orders.Add(orders);
          
        }

        public void AddProduct(string name, double price, string catagory, int count)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(string code, string newname, double newprice, int newcount, string newcatagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnBycatagory(string catagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnByPrice(string productname)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnByPriice(double starprice, double endprice)
        {
            throw new NotImplementedException();
        }

        public void ReturNoProductItem(string orderno)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByCost(double startcost, double oldcast)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByDate(string date)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByDates(string startdate, string olddata)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByOrderNo(string orderno)
        {
            throw new NotImplementedException();
        }

        public void ReturNorderItem(string order, string ordeproduct, int count)
        {
            throw new NotImplementedException();
        }
    }
}
