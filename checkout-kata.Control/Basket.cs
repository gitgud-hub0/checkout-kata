using System;
using checkout_kata.Entity;
using System.Collections.Generic;
using System.Linq;

namespace checkout_kata.Control
{
    public class Basket
    {
        public List<Items> AllItems { get; set; }

        //ShoppingBasket as dictionary with item type as key and number of items as value
        public static Dictionary<Items, int> ShoppingBasket { get; set; }



        public Basket()
        {
            ProductInfo itemInfo = new ProductInfo();
            AllItems = itemInfo.GetAllProducts();
            ShoppingBasket = new Dictionary<Items,int>();
        }

       
        public void Scan(string sku)
        {             
            try
            {
                Items item = AllItems.Find(x => x.Sku == sku);
                //if shoppingbasket already has the item then increase quantity by 1, else add the item to the basket 
                if (ShoppingBasket.ContainsKey(item)) 
                {
                    ShoppingBasket[item] += 1;
                }
                else
                {
                    ShoppingBasket.Add(item, 1);
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} Exception caught. Invalid item scanned", e);
            }
        }

        public Dictionary<Items, int> GetShoppingBasket()
        {
            return ShoppingBasket;
        }
    }

}


