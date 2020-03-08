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
        public void Test1()
        {
            basket.Scan("A99");
            Assert.AreEqual(50, basket.Total());
        }
    }
}