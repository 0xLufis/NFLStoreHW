using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S0IPAF.DataModel;

namespace S0IPAF
{
    internal partial class ItemControl : UserControl
    {
        private Item item;
        private PictureBox pictureBox;
        private Label teamNameLabel, playerNameLabel, playerNumberLabel, sizeLabel, retailPriceLabel;
        private CheckBox checkBox;
        private TextBox quantityTextBox;
        private Label quantityLabel;


        internal ItemControl(Item item)
        {
            InitializeComponent();
            this.item = item;
            InitializeControls();
            FillControls();
        }

        private void FillControls()
        {
            teamNameLabel.Text = item.TeamName;
            playerNameLabel.Text = item.PlayerName;
            playerNumberLabel.Text = item.PlayerNumber.ToString();
            sizeLabel.Text = item.Size.ToString();
            retailPriceLabel.Text = item.RetailPrice.ToString();
            pictureBox.Image = item.ImageObject;
        }

        private void InitializeControls()
        {
            this.Size = new Size(80, 800);
            this.BackColor = Color.LightCoral;
            this.BorderStyle = BorderStyle.FixedSingle;
            pictureBox = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            teamNameLabel = new Label { Location = new Point(10, 120), AutoSize = true };
            playerNameLabel = new Label { Location = new Point(10, 140), AutoSize = true };
            playerNumberLabel = new Label { Location = new Point(10, 160), AutoSize = true };
            sizeLabel = new Label { Location = new Point(10, 180), AutoSize = true };
            retailPriceLabel = new Label { Location = new Point(10, 200), AutoSize = true };
            checkBox = new CheckBox
            {
                Location = new Point(10, 220),
                Text = ""
            };
            quantityLabel = new Label
            {
                Location = new Point(10, 240),
                Text = "db"
            };
            quantityTextBox = new TextBox
            {
                Location = new Point(10, 270),
                Width = 50
            };
            this.Controls.Add(pictureBox);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(playerNameLabel);
            this.Controls.Add(playerNumberLabel);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(retailPriceLabel);
            this.Controls.Add(checkBox);
            this.Controls.Add(quantityTextBox);
            this.Controls.Add(quantityLabel);
        }
    }
}
