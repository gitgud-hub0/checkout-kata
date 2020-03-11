using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    public class DiscountsInfo : IDiscountsInfo
    {
        private List<Discounts> discountsList = new List<Discounts>()
        {
            new Discounts("A99", 3, 130),
            new Discounts("B15", 2, 45)
        };

        public List<Discounts> GetDiscountsInfo()
        {
            return discountsList;            
        }
    }
}
