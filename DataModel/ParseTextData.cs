using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF.DataModel
{
    class ParseTextData : IParseData
    {
        public List<Item> ParseData(string sourceDataFilePath)
        {
            List<Item> items = new List<Item>();
            string[] lines = System.IO.File.ReadAllLines(sourceDataFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string teamName = parts[0];
                string playerName = parts[1];
                int playerNumber = int.Parse(parts[2]);
                string size = parts[3];
                float bulkPrice = float.Parse(parts[4]);
                float retailPrice = float.Parse(parts[5]);
                string imageFilePath_Short = parts[6];
                Item item = new Item(teamName, playerName, playerNumber,size, bulkPrice, retailPrice, imageFilePath_Short);
                items.Add(item);
            }
            return items;
        }
    }
}
