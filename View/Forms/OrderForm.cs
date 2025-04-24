using S0IPAF.Model.Accounting;
using S0IPAF.Model.Jersey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S0IPAF
{
    internal partial class OrderForm : Form
    {
        internal JerseyStorage store;
        Accounting accounting;

        public OrderForm(JerseyStorage store, Accounting accounting)
        {

            this.store = store;
            InitializeComponent();
            try
            {
                ItemsTable.RowCount = store.Count();
                ItemsTable.ColumnCount = 1;
                ItemsTable.RowStyles.Clear();
                FillList(store);
                ItemsTable.Show();
                this.accounting = accounting;
            }
            catch (NoNullAllowedException)
            {
                throw new NoNullAllowedException("Hibás adat");
            }
        }


        private void FillList(JerseyStorage jerseys)
        {
            jerseys.ForEach(jersey =>
            {
                JerseyControl itemControl = new JerseyControl(jersey);
                itemControl.AutoSize = false;
                itemControl.Height = 80;
                itemControl.Width = 663;
                itemControl.Margin = new Padding(10);
                ItemsTable.Controls.Add(itemControl);
            });
        }

        private void ItemsTable_Paint(object sender, PaintEventArgs e)
        {
        }
        

        private void buttonRendeles_Click(object sender, EventArgs e)
        {
            if (CheckErrors())
            {
                int debug = 0;
                foreach (Control control in ItemsTable.Controls)
                {
                    if (control is JerseyControl jerseyControl)
                    {
                        if (jerseyControl.checkBoxBuy.Checked)
                        {
                            int id = jerseyControl.Id;
                            int count = int.Parse(jerseyControl.textBoxCount.Text);
                            Jersey jersey = store.GetByID(id);
                            jersey.Amount = count;
                            accounting.AddPurchase(jersey);
                            jerseyControl.checkBoxBuy.Checked = false;
                            jerseyControl.textBoxCount.Text = string.Empty;
                        }
                    }
                }
                accounting.NumberOfPurchases++;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kérjük, ellenőriintzze a hibákat a rendelés leadása előtt.");
                return;
            }
        }

        public bool CheckErrors()
        {
            bool noErrors = true;
            foreach (Control control in ItemsTable.Controls)
            {
                if (control is JerseyControl jerseyControl)
                {
                    if (jerseyControl.checkBoxBuy.Checked)
                    {
                        if (jerseyControl.textBoxCount.Text == null || !int.TryParse(jerseyControl.textBoxCount.Text,out int parsedValue) || parsedValue <= 0 )
                        {
                            jerseyControl.textBoxCount.BackColor = Color.Red;
                            noErrors = false;
                        }
                    }
                    jerseyControl.textBoxCount.BackColor = Color.White;
                }
            }
            return noErrors;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }


        private void OrderForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void UpdatePrice()
        {
            float total = 0;
            foreach (Control control in ItemsTable.Controls)
            {
                if (control is JerseyControl jerseyControl)
                {

                    if (!jerseyControl.checkBoxBuy.Checked && jerseyControl.textBoxCount.Text != string.Empty)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(jerseyControl.textBoxCount.Text))
                    {
                        continue;
                    }
                    if (!int.TryParse(jerseyControl.textBoxCount.Text, out int count) || count <= 0)
                    {
                        continue;
                    }
                    total += int.Parse(jerseyControl.textBoxCount.Text) * jerseyControl.price;
                }
                labelTotal.Text = string.Format("${0}", total.ToString("0.00"));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var scrollPos = this.ItemsTable.AutoScrollPosition;

            this.SuspendLayout();
            UpdatePrice();
            this.ResumeLayout();
            this.ItemsTable.AutoScrollPosition = new Point(-scrollPos.X, -scrollPos.Y);

        }
    }
}
