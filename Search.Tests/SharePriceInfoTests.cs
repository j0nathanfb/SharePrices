using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Search.Tests
{
    [TestClass]
    public class SharePriceInfoTests
    {
        [TestMethod]
        public void BestFirstMonthSharePriceInfoIsCorrect()
        {
            var info = SharePrices.GetBestBuySellInfo(_firstMonthPrices);

            Assert.AreEqual(14, info.BuyIndex);
            Assert.AreEqual(20, info.SellIndex);
        }

        [TestMethod]
        public void BestSecondMonthSharePriceInfoIsCorrect()
        {
            var info = SharePrices.GetBestBuySellInfo(_secondMonthPrices);
            Assert.AreEqual(19, info.BuyIndex);
            Assert.AreEqual(20, info.SellIndex);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullUserIdInConstructor()
        {
            SharePrices.GetBestBuySellInfo(new double[] { });
        }

        readonly double[] _firstMonthPrices = new double[] { 18.93, 20.25, 17.05, 16.59, 21.09, 16.22, 21.43, 27.13, 18.62, 21.31, 23.96, 25.52, 19.64, 23.49, 15.28, 22.77, 23.1, 26.58, 27.03, 23.75, 27.39, 15.93, 17.83, 18.82, 21.56, 25.33, 25, 19.33, 22.08, 24.03 };
        readonly double[] _secondMonthPrices = new double[] { 22.74, 22.27, 20.61, 26.15, 21.68, 21.51, 19.66, 24.11, 20.63, 20.96, 26.56, 26.67, 26.02, 27.20, 19.13, 16.57, 26.71, 25.91, 17.51, 15.79, 26.19, 18.57, 19.03, 19.02, 19.97, 19.04, 21.06, 25.94, 17.03, 15.61 };
    }
}
