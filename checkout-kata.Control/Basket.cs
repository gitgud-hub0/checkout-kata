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
        public Dictionary<Items, int> ShoppingBasket { get; set; }

        public double TotalPrice { get; set; }

        public Basket()
        {
            ProductInfo itemInfo = new ProductInfo();
            AllItems = itemInfo.GetAllProducts();
            ShoppingBasket = new Dictionary<Items,int>();
            TotalPrice = 0;
        }

       
        public void Scan(string sku)
        {
            Items item = AllItems.Find(x => x.Sku == sku);

            //if shoppingbasket already has the item then increase quantity by 1, else add the item to the basket   
            if (ShoppingBasket.ContainsKey(item))
            {
                ShoppingBasket[item] += 1; 
            }
            else
            {
                ShoppingBasket.Add(item,1);
            }

            TotalPrice += item.UnitPrice;
        }

        public double Total()
        {
            double totalDiscounts = 0;

            foreach (var item in ShoppingBasket)
            {
                int basketItemQuantity = item.Value;
                double unitPrice = item.Key.UnitPrice;
                int requiredDiscountQuantity = item.Key.ItemDiscountQuantity;
                int itemDiscountPrice = item.Key.ItemDiscountPrice;
                double discountAppliedAmount = 0;

                int discountAppliedCount = basketItemQuantity / requiredDiscountQuantity;
                discountAppliedAmount = (unitPrice * requiredDiscountQuantity * discountAppliedCount) - discountAppliedCount * itemDiscountPrice;
                totalDiscounts += discountAppliedAmount;


            }                
            return TotalPrice - totalDiscounts;
        }
    }

}


