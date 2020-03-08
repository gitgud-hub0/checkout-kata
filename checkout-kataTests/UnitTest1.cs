using NUnit.Framework;
using checkout_kata.Entity;
using checkout_kata.Control;

namespace checkout_kataTests
{
    public class Tests
    {
        Basket basket = new Basket();

        [SetUp]
        public void Setup()
        {
            basket = new Basket();
        }

        [Test]
        public void ScanOneApple()
        {
            basket.Scan("A99");
            Assert.AreEqual(50, basket.Total());
        }

        [Test]
        public void ScanTwoItems()
        {
            basket.Scan("B15");
            basket.Scan("A99");
            Assert.AreEqual(80, basket.Total());
        }

        [Test]
        public void ScanThreeApplesForDiscounts()
        {
            for (int i = 0; i < 3; i++)
            {
                basket.Scan("A99");
            }
            Assert.AreEqual(130, basket.Total());
        }

        [Test]
        public void ScanTwoBiscuits()
        {
            for (int i = 0; i < 2; i++)
            {
                basket.Scan("B15");
            }
            Assert.AreEqual(45, basket.Total());
        }

        [Test]
        public void ScanSixApples()
        {
            for (int i = 0; i < 6; i++)
            {
                basket.Scan("A99");
            }
            Assert.AreEqual(260, basket.Total());
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
            Assert.AreEqual(205, basket.Total());
        }

        //After first hour
        [Test]
        public void ScanInvalid()
        {
            basket.Scan("A98");
            Assert.AreEqual(0, basket.Total());
        }

        [Test]
        public void ScanOneInvalidAndOneApple()
        {
            basket.Scan("A98");
            basket.Scan("A99");
            Assert.AreEqual(50, basket.Total());
        }
    }
}