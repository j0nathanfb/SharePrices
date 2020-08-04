using Interfaces;
using Model;
using Search;
using System;
using System.IO;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the full path to the text file containing the share data");
                var path = Console.ReadLine();

                IShareData reader = new ShareFileReader(path);
                var data = reader.GetShareData();

                var buySellIndices = SharePrices.GetBestBuySellIndices(data);

                var info = new BuySellInfo(data, buySellIndices.Item1, buySellIndices.Item2);

                Console.WriteLine(info.ToString());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Share data file not found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Shares file is not in correct format.");
            }
        }


    }
}
