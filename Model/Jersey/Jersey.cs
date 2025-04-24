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
        string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Res\\Images");
        internal int ID { get; }
        internal string TeamName { get; }
        internal string PlayerName { get;}
        internal int PlayerNumber { get; }

        internal string Size { get; }
        internal float BulkPrice { get; }
        internal float RetailPrice { get; }
        internal string ImageName { get; }
        internal Bitmap ImageObject { get; }
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

        private Bitmap GetImageObject(string imageName)
        {
            try
            {
                // Check if the image exists in the resources -- Not used
                /*
                  if ( Properties.Resources.ResourceManager.GetObject(imageName) is Bitmap bitmap)
                  {
                      return bitmap;
                  }
                */
                // Check if the image exists in the images folder
                string imagePath = Path.Combine(imagesFolder, imageName);
                if (File.Exists(imagePath))
                {
                    Bitmap image = new Bitmap(imagePath);
                    return image;
                }
                // If the image is not found, throw an exception
                throw new Exception("File does not exist: " + imagePath);


            }
            catch (Exception ex)
            {

                throw new Exception("No such image: " + imageName + "Excetpion: " + ex.Message);
            }


        }

        internal float GetSubtotalPrice(int amount)
        {
            return amount * BulkPrice;
        }
    }
}
