using System;

namespace Search
{
    public class SharePrices
    {
        public static BuySellInfo GetBestBuySellInfo(double[] sharePrices)
        {
            if (sharePrices.Length == 0) throw new ArgumentException("sharePrices array is empty!", nameof(sharePrices));

            var info = new BuySellInfo();
            var maxIncrease = 0.0;

            for (var i = 0; i < sharePrices.Length - 1; i++)
            {
                for (var j = i + 1; j < sharePrices.Length; j++)
                {
                    if (sharePrices[j] - sharePrices[i] > maxIncrease)
                    {
                        maxIncrease = sharePrices[j] - sharePrices[i];
                        info.BuyIndex = i;
                        info.SellIndex = j;
                    }
                }
            }

            return info;
        }
    }
}
