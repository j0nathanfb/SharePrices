namespace Search
{
    public class BuySellInfo
    {
        public int BuyIndex { get; set; }
        public int SellIndex { get; set; }

        public override string ToString()
        {
            return $"Buy : {BuyIndex}, Sell: {SellIndex}";
        }
    }
}
