using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF.DataModel
{
    class Item
    {
        static string ImageDirectoryPath = Path.Combine(Environment.CurrentDirectory, "Images");
        public string TeamName { get; }
        public string PlayerName { get; }
        public int PlayerNumber { get; }
        public string Size  { get;}
        public float BulkPrice { get; }
        public float RetailPrice { get; }
        public string ImageFileName { get; }
        public Image ImageObject { get; }


        public Item(string teamName, string playerName, int playerNumber, string size, float bulkPrice, float retailPrice, string imageFilenName)
        {
            TeamName = teamName;
            PlayerName = playerName;
            PlayerNumber = playerNumber;
            BulkPrice = bulkPrice;
            RetailPrice = retailPrice;
            ImageFileName = imageFilenName;
            Size = size;
            
            ImageObject = GetImageObject(imageFilenName);
        }

        public Image GetImageObject(string imageFileName)
        {
            try
            {
                string imagePath = Path.Combine(ImageDirectoryPath, imageFileName);

                // Handles if the image file exists gracefully
                if (!File.Exists(imagePath))
                {
                    throw new FileNotFoundException($"Image file not found: {imagePath}");
                }

                return Image.FromFile(imagePath);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
