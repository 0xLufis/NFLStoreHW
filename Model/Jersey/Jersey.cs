using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Policy;

namespace S0IPAF.Model.Jersey
{
    class Jersey
    {
        string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
        
        internal int ID { get; }
        internal string TeamName { get; }
        internal string PlayerName { get;}
        internal int PlayerNumber { get; }
        internal string Size { get; }
        internal float BulkPrice { get; }
        internal float RetailPrice { get; }
        internal string ImageName { get; }
        internal Image ImageObject { get; }
        internal int Amount  { get; set; }

        public Jersey(string teamName, string playerName, int playerNumber, string size, float bulkPrice, float retailPrice, string imageName) 
        { 
            this.TeamName = teamName;
            this.PlayerName = playerName;
            this.PlayerNumber = playerNumber;
            this.Size = size;
            this.BulkPrice = bulkPrice;
            this.RetailPrice = retailPrice;
            this.ImageName = imageName;
            this.ImageObject = GetImageObject(imageName);
            this.Amount = 0;
            this.ID = GetHashCode();
        }

        private Image GetImageObject(string imageName)
        {
            string imagePath = Path.Combine(imagesFolder, imageName);

            if (!File.Exists(imagePath))
            {
                MessageBox.Show($"Fájl nem található: {imagePath}");
                return null;
            }

            return Image.FromFile(imagePath);
        }

        internal float GetSubtotalPrice(int amount)
        {
            return amount * BulkPrice;
        }
    }
}
