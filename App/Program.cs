using Interfaces;
using Model;
using Search;
using System;
using System.IO;

namespace App
{
    class Program
    {
        /// <summary>
        /// Command-line test harness for share price coding challenge. 
        /// </summary>
        /// <param name="args">Set args[0] to full path to file for debugging.</param>
        static void Main(string[] args)
        {
            try
            {
                string path;

                if (args.Length == 0)
                {
                    Console.WriteLine("Please enter the full path to the text file containing the share data");

                    path = Console.ReadLine();
                }
                else
                {
                    path = args[0];
                }

                IShareData reader = new ShareFileReader(path);
                var data = reader.GetShareData();

                var buySellIndices = SharePrices.GetBestBuySellIndices(data);

                var info = new BuySellInfo(data, buySellIndices.Item1, buySellIndices.Item2);

                Console.WriteLine(info.ToString());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Shares data file not found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Shares data file is not in correct format. It should be a comma separated list of prices.");
            }
        }


    }
}
