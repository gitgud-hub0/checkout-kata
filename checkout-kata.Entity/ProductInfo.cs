using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    public class ProductInfo
    {
        List<Items> productsList = new List<Items>()
        {
            new Items("A99", 50),
            new Items("B15", 30),
            new Items("C40", 60),
            new Items("T34", 99)
        };

        public List<Items> GetAllProducts()
        {
             return productsList;
        }
    }
}
