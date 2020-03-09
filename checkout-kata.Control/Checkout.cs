using System;
using System.Collections.Generic;
using System.Text;
using checkout_kata.Entity;

namespace checkout_kata.Control
{
    public class Checkout
    {
        public double TotalPrice { get; set; }

        public Dictionary<Items, int> CheckoutBasket { get; set; }

        public Checkout()
        {
            TotalPrice = 0;
            Basket basket = new Basket();            
            CheckoutBasket = basket.GetShoppingBasket();
        }

        //calculates the total price and applies any discounts 
        public double CalculateTotal()
        {
            double subtotalPrice = 0;

            foreach (var item in CheckoutBasket)
            {
                int basketItemQuantity = item.Value;
                double unitPrice = item.Key.UnitPrice;
                int requiredDiscountQuantity = item.Key.ItemDiscountQuantity;
                int itemDiscountPrice = item.Key.ItemDiscountPrice;
                double discountAppliedAmount = 0;

                int discountAppliedCount = basketItemQuantity / requiredDiscountQuantity;
                discountAppliedAmount = (unitPrice * requiredDiscountQuantity * discountAppliedCount) - discountAppliedCount * itemDiscountPrice;

                double totalPriceNoDiscounts = basketItemQuantity * unitPrice;
                double discountedPrice = totalPriceNoDiscounts - discountAppliedAmount;

                subtotalPrice += discountedPrice;
            }
            return TotalPrice = subtotalPrice;
        }

    }
}
