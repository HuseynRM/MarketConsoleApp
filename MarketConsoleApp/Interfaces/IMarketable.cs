using MarketConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketConsoleApp.Interfaces
{
    interface IMarketable
    {
        List<Order> Orders { get; set; }
        List<Product> products { get; set; }
        void Addorder(Order orders);
        void ReturNorderItem(string order , string ordeproduct , int count );
        void ReturNoProductItem(string orderno);
        List<Order> ReturnOrderByDates(string startdate, string olddate);
        List<Order> ReturnOrderByDate(string date);
        List<Order> ReturnOrderByCost(double startcost, double oldcost);
        List<Order> ReturnOrderByOrderNo(string orderno);
        void AddProduct(string name, double price, string catagory, int count);
        void EditProduct(string code , string newname ,double newprice,int newcount , string newcatagory);
        List<Product> ReturnBycatagory(string catagory);
        List<Product> ReturnByPriice(double starprice, double endprice);
        List<Product> ReturnByPrice(string productname);

    }
}
