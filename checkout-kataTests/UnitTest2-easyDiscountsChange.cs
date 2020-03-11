using NUnit.Framework;
using checkout_kata.Entity;
using checkout_kata.Control;

namespace checkout_kataTests
{
    public class TestsEasyDiscountsChange
    {
        Basket basket = new Basket();
        Checkout checkout = new Checkout();

        [SetUp]
        public void Setup()
        {
            basket = new Basket();
            checkout = new Checkout();
        }

        [Test]
        public void ScanOneApple()
        {

            basket.Scan("A99");

            Assert.AreEqual(50, checkout.CalculateTotal());
        }

        [Test]
        public void ScanTwoItems()
        {
            basket.Scan("B15");
            basket.Scan("A99");
            Assert.AreEqual(80, checkout.CalculateTotal());
        }

        [Test]
        public void ScanThreeApplesForDiscounts()
        {
            for (int i = 0; i < 3; i++)
            {
                basket.Scan("A99");
            }
            Assert.AreEqual(130, checkout.CalculateTotal());
        }

        [Test]
        public void ScanTwoBiscuits()
        {
            for (int i = 0; i < 2; i++)
            {
                basket.Scan("B15");
            }
            Assert.AreEqual(45, checkout.CalculateTotal());
        }

        [Test]
        public void ScanSixApples()
        {
            for (int i = 0; i < 6; i++)
            {
                basket.Scan("A99");
            }
            Assert.AreEqual(260, checkout.CalculateTotal());
        }

        [Test]
        public void ScanThreeBiscuitsAndThreeApples()
        {
            for (int i = 0; i < 3; i++)
            {
                basket.Scan("B15");
            }
            for (int i = 0; i < 3; i++)
            {
                basket.Scan("A99");
            }
            Assert.AreEqual(205, checkout.CalculateTotal());
        }

        //After first hour
        [Test]
        public void ScanInvalid()
        {
            basket.Scan("A98");
            Assert.AreEqual(0, checkout.CalculateTotal());
        }

        [Test]
        public void ScanOneInvalidAndOneApple()
        {
            basket.Scan("A98");
            basket.Scan("A99");
            Assert.AreEqual(50, checkout.CalculateTotal());
        }
    }
}