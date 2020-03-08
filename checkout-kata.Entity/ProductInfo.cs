using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    public class ProductInfo
    {
        //this method initialises all products as different instances of Items class
        public List<Items> GetAllProducts()
        {
            List<Items> productsList = new List<Items>()
            {
                new Items("A99", 50, 3, 130),
                new Items("B15", 30, 2, 45),
                new Items("C40", 60),
                new Items("T34", 99)
            };

            return productsList;
        }
    }
}
