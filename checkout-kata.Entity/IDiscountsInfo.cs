using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.Entity
{
    interface IDiscountsInfo
    {
        public List<Discounts> GetDiscountsInfo();
    }
}
