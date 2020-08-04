namespace Model
{
    /// <summary>
    /// Model representing share price buy and sell days and their associated prices.
    /// </summary>
    public class BuySellInfo
    {
        public int BuyDay { get; }
        public double BuyPrice { get; }
        public int SellDay { get; }
        public double SellPrice { get; }

        public BuySellInfo(double[] shareData, int buyIndex, int sellIndex)
        {
            BuyDay = MapIndexToDayNumber(buyIndex);
            SellDay = MapIndexToDayNumber(sellIndex);
            BuyPrice = shareData[buyIndex];
            SellPrice = shareData[sellIndex];
        }

        public override string ToString()
        {
            return $"{BuyDay}({BuyPrice}),{SellDay}({SellPrice})";
        }

        /// <summary>
        /// Map the zero-based index to day of the month
        /// </summary>
        private int MapIndexToDayNumber(int index)
        {
            return ++index;
        }
    }
}
