using System;
using checkout_kata.Entity;
using System.Collections.Generic;
using System.Linq;

namespace checkout_kata.Control
{
    public class Basket
    {
        public List<Items> AllItems { get; set; }

        public List<Items> ShoppingBasket { get; set; }

        public double TotalPrice { get; set; }

        public Basket()
        {
            ProductInfo itemInfo = new ProductInfo();
            AllItems = itemInfo.GetAllProducts();
            ShoppingBasket = new List<Items>();
            TotalPrice = 0;
        }

       
        public void Scan(string sku)
        {
            Items item = AllItems.Find(x => x.Sku == sku);
            TotalPrice += item.UnitPrice;
        }

        public double Total()
        {
            return TotalPrice;
        }
    }

}


