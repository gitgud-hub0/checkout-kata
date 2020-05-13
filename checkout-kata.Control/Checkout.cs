using System;
using System.Collections.Generic;
using System.Text;
using checkout_kata.Entity;
using System.Linq;

namespace checkout_kata.Control
{
    public class Checkout
    {
        public double TotalPrice { get; set; }

        public Dictionary<Items, int> CheckoutBasket { get; set; }

        public List<Discounts> AllDiscountsInfo { get; set; }

        public Checkout()
        {
            TotalPrice = 0;
            Basket basket = new Basket();            
            CheckoutBasket = basket.GetShoppingBasket();
            
            //AllDiscountsInfo = DiscountsInfo.DiscountsList;
        }

        //calculates the total price and applies any discounts 
        public double CalculateTotal()
        {
            double subtotalPrice = 0;

            foreach (var item in CheckoutBasket)
            {
                int basketItemQuantity = item.Value;
                double unitPrice = item.Key.UnitPrice;
               

                
                var Discount = DiscountsInfo.DiscountsList.FirstOrDefault(x => x.Sku == item.Key.Sku);

                var requiredDiscountQuantity = Discount?.ItemDiscountQuantity ?? 0;
                var itemDiscountPrice = Discount?.ItemDiscountPrice ?? 0;

                double discountAppliedAmount = 0;

                if (requiredDiscountQuantity != 0)
                {
                   int discountAppliedCount = basketItemQuantity / requiredDiscountQuantity;
                    discountAppliedAmount = (unitPrice * requiredDiscountQuantity * discountAppliedCount) - discountAppliedCount * itemDiscountPrice;
                };
 
                double totalPriceNoDiscounts = basketItemQuantity * unitPrice;
                double discountedPrice = totalPriceNoDiscounts - discountAppliedAmount;

                subtotalPrice += discountedPrice;
            }
            return TotalPrice = subtotalPrice;
        }

    }
}
