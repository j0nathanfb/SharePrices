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
            Assert.AreEqual(15.28, info.BuyPrice);
        }

        [TestMethod]
        public void SellPriceIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);
            Assert.AreEqual(27.39, info.SellPrice);
        }

        [TestMethod]
        public void ToStringMessageIsCorrect()
        {
            var info = new BuySellInfo(_shareData, 14, 20);

            var str = info.ToString();

            Assert.AreEqual("15(15.28),21(27.39)", info.ToString());
        }

        readonly double[] _shareData = new double[] { 18.93, 20.25, 17.05, 16.59, 21.09, 16.22, 21.43, 27.13, 18.62, 21.31, 23.96, 25.52, 19.64, 23.49, 15.28, 22.77, 23.1, 26.58, 27.03, 23.75, 27.39, 15.93, 17.83, 18.82, 21.56, 25.33, 25, 19.33, 22.08, 24.03 };
    }
}
