using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S0IPAF.Model.Jersey;

namespace S0IPAF
{
    internal partial class JerseyControl : UserControl
    {
        internal int Id { get; private set; }
        internal float price;
        internal JerseyControl(Jersey jersey)
        {
            InitializeComponent();
            LoadData(jersey);
            this.textBoxCount.Enabled = false;
        }

        private void LoadData(Jersey jersey)
        {
            this.Id = jersey.ID;
            string sPrice = jersey.RetailPrice.ToString("0.00 "); 
            labelTeamName.Text = jersey.TeamName;
            labelPlayerName.Text = jersey.PlayerName;
            labelPlayerNumber.Text = jersey.PlayerNumber.ToString();
            labelSize.Text = jersey.Size;
            labelPrice.Text = string.Format("$ {0}", sPrice);
            pictureBoxJersey.Image = jersey.ImageObject;
            price = jersey.RetailPrice;
        }
        private void checkBoxBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuy.Checked)
            {
                textBoxCount.Enabled = true;
                textBoxCount.Focus();
            }
            else
            {
                textBoxCount.Enabled = false;
            }
        }

    }
}
