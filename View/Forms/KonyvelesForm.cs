using S0IPAF.Model.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF.View
{
    public partial class KonyvelesForm: Form
    {
        internal Accounting accounting;
        internal KonyvelesForm(Accounting accountingIn)
        {
            InitializeComponent();
            this.accounting = accountingIn;
            this.labelRendelesekAmount.Text = accounting.NumberOfPurchases.ToString() + " db";
            this.labelPurchaseCost.Text = "$" + accounting.NetCost.ToString();
            this.labelNetProfit.Text = "$" + accounting.NetIncome.ToString();
            this.labelProfit.Text = "$" +  accounting.Profit.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
