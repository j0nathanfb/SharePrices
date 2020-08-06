using System;

namespace Search
{
    /// <summary>
    /// Algorithms for searching share prices.
    /// </summary>
    public class SharePrices
    {
        /// <summary>
        /// Gets the BuyIndex and SellIndex of the sharePrices list to provide the best profit range.
        /// </summary>
        /// <param name="sharePrices">List of share prices in chronological order.</param>
        /// <returns>Best buy and sell indices for the given range of values. The First item is the Buy Day index. The second item is Sell Day index</returns>
        public static Tuple<int, int> GetBestBuySellIndices(decimal[] sharePrices)
        {
            if (sharePrices.Length == 0) throw new ArgumentException("sharePrices array is empty", nameof(sharePrices));
            // Todo: JB 06/08/2020 Checking for length greater than 30. Should this be greater than 31? Need to confirm.
            if (sharePrices.Length > 30) throw new ArgumentException("sharePrices array length is greater than 30", nameof(sharePrices));

            var maxIncrease = 0.0M;

            var buyIndex = 0;
            var sellIndex = 0;

            for (var i = 0; i < sharePrices.Length - 1; i++)
            {
                for (var j = i + 1; j < sharePrices.Length; j++)
                {
                    if (sharePrices[j] - sharePrices[i] > maxIncrease)
                    {
                        maxIncrease = sharePrices[j] - sharePrices[i];

                        buyIndex = i;
                        sellIndex = j;
                    }
                }
            }

            return new Tuple<int, int>(buyIndex, sellIndex);
        }
    }
}
