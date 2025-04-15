using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S0IPAF.Model.Jersey;

namespace S0IPAF.Model.Accounting
{
    class SaleItem
    {
        public int id { get; }
        public int count {get; }
        public float subtotal { get; }
        public SaleItem(Jersey.Jersey jersey) 
        {
            this.id = jersey.ID;
            this.count = jersey.Amount;
            this.subtotal = jersey.GetSubtotalPrice(jersey.Amount);
        }
    }
}
