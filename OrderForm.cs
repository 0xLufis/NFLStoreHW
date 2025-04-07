using S0IPAF.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF
{
    internal partial class OrderForm: Form
    {
        internal ItemStore store = new ItemStore();   
        public OrderForm(ItemStore store)
        {
            InitializeComponent();
            this.store = store;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            InitializeList();
            FillList(store);
            // Load the form and initialize any components if necessary
        }

        public void InitializeList()
        {
            ItemsPanel.Dock = DockStyle.Fill;
            ItemsPanel.AutoScroll = true;
            ItemsPanel.WrapContents = true;
            ItemsPanel.FlowDirection = FlowDirection.TopDown;
            this.Controls.Add(ItemsPanel);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private void FillList(ItemStore itemStore)
        {
            List<Item> items = itemStore.GetAvailableItems();
            items.ForEach(item =>
            {
                ItemControl itemControl = new ItemControl(item);
                itemControl.Dock = DockStyle.Top;
                itemControl.AutoSize = true;
                itemControl.Margin = new Padding(10);
                ItemsPanel.Controls.Add(itemControl);
            });
        }
    }
}
