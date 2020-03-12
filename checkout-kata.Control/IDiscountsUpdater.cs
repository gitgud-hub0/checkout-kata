using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Control
{
    interface IDiscountsUpdater
    {
        public void UpdateDiscountsInfo(string sku, int discountQuantity, double discountPrice);
    }
}
