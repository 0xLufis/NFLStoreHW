using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }

    class Store 
    {
        private readonly string imageRootPath = Application.StartupPath;

        private List<Item> AvailableItems;
    }

    class Item
    {
        private string TeamName { get;  }
        private string PlayerName { get; }
        private string PlayerNumber { get; }
        private double BulkPrice { get; }
        private double RetailPrice { get; }
        private string ImageFilePath_Short { get; }

        Item(string teamName, string playerName, string playerNumber, double bulkPrice, double retailPrice, string imageFilePath_Short)
        {
            TeamName = teamName;
            PlayerName = playerName;
            PlayerNumber = playerNumber;
            BulkPrice = bulkPrice;
            RetailPrice = retailPrice;
            ImageFilePath_Short = imageFilePath_Short;
        }
    }
}
