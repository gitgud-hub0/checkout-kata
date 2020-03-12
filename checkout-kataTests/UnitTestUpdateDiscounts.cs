using NUnit.Framework;
using checkout_kata.Entity;
using checkout_kata.Control;

namespace checkout_kataTests
{
    public class UpdateDiscountsTest
    {
        DiscountsUpdater discountsUpdater = new DiscountsUpdater();

        [SetUp]
        public void Setup()
        {
            discountsUpdater = new DiscountsUpdater();
        }

        [Test]
        public void AddNewAppleDiscounts()
        {
            discountsUpdater.UpdateDiscountsInfo("A99", 3, 130);
            Assert.IsTrue(DiscountsInfo.DiscountsList.Exists(x => x.Sku == "A99"));
        }

        [Test]
        public void UpdateAppleDiscounts()
        {
            discountsUpdater.UpdateDiscountsInfo("A99", 3, 130);
            discountsUpdater.UpdateDiscountsInfo("A99", 4, 260);

            Discounts discounts = discountsUpdater.AllDiscounts.Find(x => x.Sku == "A99");
            int expectDiscountsQuantity = discounts.ItemDiscountQuantity;
            double expectDiscountPrice = discounts.ItemDiscountPrice;

            Assert.AreEqual(expectDiscountsQuantity, 4);
            Assert.AreEqual(expectDiscountPrice, 260);
        }
    }
}