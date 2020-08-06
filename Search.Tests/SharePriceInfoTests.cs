using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Search.Tests
{
    [TestClass]
    public class SharePriceInfoTests
    {
        [TestMethod]
        public void BestFirstMonthSharePriceInfoIsCorrect()
        {
            var info = SharePrices.GetBestBuySellIndices(_firstMonthPrices);

            Assert.AreEqual(14, info.Item1);
            Assert.AreEqual(20, info.Item2);
        }

        [TestMethod]
        public void BestSecondMonthSharePriceInfoIsCorrect()
        {
            var info = SharePrices.GetBestBuySellIndices(_secondMonthPrices);
            Assert.AreEqual(19, info.Item1);
            Assert.AreEqual(20, info.Item2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetBestBuySellIndicesThrowsExceptionForEmptyArray()
        {
            SharePrices.GetBestBuySellIndices(new decimal[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetBestBuySellIndicesThrowsExceptionWhenInputLengthIsGreaterThanThirty()
        {
            var input = Enumerable.Range(1, 31).Select(x => (decimal)x).ToArray();
            SharePrices.GetBestBuySellIndices(input);
        }

        readonly decimal[] _firstMonthPrices = new decimal[] { 18.93M, 20.25M, 17.05M, 16.59M, 21.09M, 16.22M, 21.43M, 27.13M, 18.62M, 21.31M, 23.96M, 25.52M, 19.64M, 23.49M, 15.28M, 22.77M, 23.1M, 26.58M, 27.03M, 23.75M, 27.39M, 15.93M, 17.83M, 18.82M, 21.56M, 25.33M, 25, 19.33M, 22.08M, 24.03M };
        readonly decimal[] _secondMonthPrices = new decimal[] { 22.74M, 22.27M, 20.61M, 26.15M, 21.68M, 21.51M, 19.66M, 24.11M, 20.63M, 20.96M, 26.56M, 26.67M, 26.02M, 27.20M, 19.13M, 16.57M, 26.71M, 25.91M, 17.51M, 15.79M, 26.19M, 18.57M, 19.03M, 19.02M, 19.97M, 19.04M, 21.06M, 25.94M, 17.03M, 15.61M };
    }
}
