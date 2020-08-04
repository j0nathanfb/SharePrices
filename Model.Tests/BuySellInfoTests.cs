using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass]
    public class BuySellInfoTests
    {
        [TestMethod]
        public void BuyDayIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);

            Assert.AreEqual(15, info.BuyDay);
        }

        [TestMethod]
        public void SellDayIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);
            Assert.AreEqual(21, info.SellDay);
        }

        [TestMethod]
        public void BuyPriceIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);
            Assert.AreEqual(15.28M, info.BuyPrice);
        }

        [TestMethod]
        public void SellPriceIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);
            Assert.AreEqual(27.39M, info.SellPrice);
        }

        [TestMethod]
        public void ToStringMessageIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);

            Assert.AreEqual("15(15.28),21(27.39)", info.ToString());
        }

        private readonly decimal[] _shareData = { 18.93M, 20.25M, 17.05M, 16.59M, 21.09M, 16.22M, 21.43M, 27.13M, 18.62M, 21.31M, 23.96M, 25.52M, 19.64M, 23.49M, 15.28M, 22.77M, 23.1M, 26.58M, 27.03M, 23.75M, 27.39M, 15.93M, 17.83M, 18.82M, 21.56M, 25.33M, 25, 19.33M, 22.08M, 24.03M };
    }
}
