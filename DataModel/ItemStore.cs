using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S0IPAF.DataModel
{
    internal class ItemStore 
    {
        private List<Item> AvailableItems;
        public ItemStore(string sourceDataFilePath, IParseData parser)
        {
            AvailableItems = new List<Item>();
            LoadData(sourceDataFilePath, parser);
        }
        
        public ItemStore()
        {
            AvailableItems = new List<Item>();
        }

        public void LoadData(string sourceDataFilePath, IParseData parser)
        {
            this.AvailableItems.Clear();
            this.AvailableItems = parser.ParseData(sourceDataFilePath);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Item item in AvailableItems)
            {
                sb.AppendLine($"Team: {item.TeamName}, Player: {item.PlayerName}, Number: {item.PlayerNumber}, Bulk Price: {item.BulkPrice}, Retail Price: {item.RetailPrice}, Image: {item.ImageFileName}");
            }
            return sb.ToString();
        }

        public List<Item> GetAvailableItems()
        {
            return AvailableItems;
        }

    }
}
