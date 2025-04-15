using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S0IPAF.Model.Jersey;

namespace S0IPAF.Model.Accounting
{
    internal class Accounting
    {
        internal int NumberOfPurchases {get; set; }
        internal float NetIncome { get; set; }
        internal float NetCost { get; set; }
        internal float Profit { get; set; }
        public Accounting() 
        {

        }

        public void AddPurchase(Jersey.Jersey jersey)
        {
            this.NetIncome += jersey.RetailPrice * jersey.Amount;
            this.NetCost += jersey.BulkPrice * jersey.Amount;
            if (jersey == null) return;
            this.Profit = NetIncome - NetCost;
        }

        public void Clear()
        {
            this.NetIncome = 0;
            this.NetCost = 0;
            this.Profit = 0;
            NumberOfPurchases = 0;
        }

    }
}
