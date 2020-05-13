using System;
using System.Collections.Generic;
using System.Text;
using checkout_kata.Entity;

namespace checkout_kata.Control
{
    public class DiscountsUpdater : IDiscountsUpdater
    {
        public List<Discounts> AllDiscounts { get; set; }

        public DiscountsUpdater()
        {
            DiscountsInfo discountsInfo = new DiscountsInfo();
            AllDiscounts = discountsInfo.GetDiscountsInfo();
        }

        public void UpdateDiscountsInfo(string sku, int discountQuantity, double discountPrice)
        {
            try
            {
                //if discounts with the sku as the primary key exist then update the discounts, else add new discounts with sku
                if (AllDiscounts.Exists(x => x.Sku == sku))
                {
                    Discounts discounts = AllDiscounts.Find(x => x.Sku == sku);
                    discounts.ItemDiscountQuantity = discountQuantity;
                    discounts.ItemDiscountPrice = discountPrice;
                }
                else
                {
                    DiscountsInfo.DiscountsList.Add(new Discounts(sku, discountQuantity, discountPrice)); 
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} Exception caught, Update Discounts Failed", e);
            }
        }

    }
}
