using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    public class Items
    {
        public string Sku { get; set; }
        public double UnitPrice { get; set; }
/*        public int ItemDiscountQuantity { get; set; }
        public int ItemDiscountPrice { get; set; }*/

        public Items(string sku, double unitPrice)
        {
            this.Sku = sku;
            this.UnitPrice = unitPrice;
        }

/*        public Items(string sku, double unitPrice, int itemDiscountQuantity, int itemDiscountPrice)
        {
            this.Sku = sku;
            this.UnitPrice = unitPrice;
            this.ItemDiscountQuantity = itemDiscountQuantity;
            this.ItemDiscountPrice = itemDiscountPrice;

        }*/
    }
}
