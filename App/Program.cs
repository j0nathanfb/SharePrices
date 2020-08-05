using CommandLine;
using Interfaces;
using Model;
using Search;
using System;
using System.IO;


namespace App
{
    public class Options
    {
        [Option('p', "path", Required = true, HelpText = "Enter full path to the share .txt file.")]
        public string Path { get; set; }
    }

    class Program
    {
        /// <summary>
        /// Command-line test harness for share price coding challenge. 
        /// </summary>
        /// <param name="args">Set args[0] to full path to file for debugging.</param>
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    try
                    {
                        Console.WriteLine(GetBuySellInfo(o.Path));
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine($"Shares data file not found.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Shares data file is not in correct format. It should be a comma separated list of prices.");
                    }
                });
        }

        private static BuySellInfo GetBuySellInfo(string path)
        {
            IShareData fileReader = new ShareFileReader(path);
            var data = fileReader.GetShareData();

            var buySellIndices = SharePrices.GetBestBuySellIndices(data);

            var shareInfo = new BuySellInfo(data, buySellIndices.Item1, buySellIndices.Item2);

            return shareInfo;
        }
    }
}
