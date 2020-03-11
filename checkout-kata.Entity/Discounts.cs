﻿using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    public class Discounts
    {
        public string Sku { get; set; }
        
        public int ItemDiscountQuantity { get; set; }

        public int ItemDiscountPrice { get; set; }

        public Discounts(string sku, int itemDiscountQuantity, int itemDiscountPrice )
        {
            this.Sku = sku;
            this.ItemDiscountQuantity = itemDiscountQuantity;
            this.ItemDiscountPrice = itemDiscountPrice;
        }
    }
}
