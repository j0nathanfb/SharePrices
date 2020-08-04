using Interfaces;
using System;
using System.IO;
using System.Linq;

namespace App
{
    /// <summary>
    /// Represents a share data interface for reading share data from a text file.
    /// The text file should contain a comma separated list of share prices for a month.
    /// </summary>
    internal class ShareFileReader : IShareData
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filePath">Full path to the text file</param>
        internal ShareFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public decimal[] GetShareData()
        {
            var sharePriceText = GetSharePriceText(_filePath);
            var data = GetSharePriceData(sharePriceText);

            return data;
        }

        private static string GetSharePriceText(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("File not found", filePath);

            return File.ReadAllText(filePath);
        }

        static decimal[] GetSharePriceData(string sharePriceText)
        {
            return sharePriceText.Split(',').Select(Convert.ToDecimal).ToArray();
        }

        private readonly string _filePath;
    }
}
