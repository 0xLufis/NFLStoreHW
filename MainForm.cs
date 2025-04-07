using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S0IPAF.DataModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S0IPAF
{
    public partial class MainForm : Form
    {
        private ItemStore store = new ItemStore();

        public MainForm()
        {
            InitializeComponent();
        }

        private void fájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
            "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        }

        private void OpenFileDialogLoadData_FileOk(object sender, CancelEventArgs e)
        {
            ParseTextData parser = new ParseTextData();
            store.LoadData(openFileDialog1.FileName, parser);
            MessageBox.Show(store.ToString());
            Application.DoEvents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(store);
            orderForm.Show();

        }
    }
}
