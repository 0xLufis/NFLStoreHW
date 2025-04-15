using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S0IPAF.Model.Accounting;
using S0IPAF.Model.Jersey;
using S0IPAF.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S0IPAF
{
    public partial class MainForm : Form
    {
        private Accounting accounting = new Accounting();
        private JerseyStorage store;

        public MainForm()
        {
            InitializeComponent();
            this.Cursor = Cursors.Arrow;
        }

        private void fájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
            "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        }

        private void OpenFileDialogLoadData_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            if (fileName == null) return;
            try
            {
                store = new JerseyStorage();
                string[] lines = File.ReadAllLines(fileName);
                IJerseyParser parser = new TxtJerseyParser();
                List<Jersey> jerseys = parser.Parse(lines);
                store.AddRange(jerseys);
                reToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl betöltésekor: " + ex.Message);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void OrderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(store,accounting);
            orderForm.Show();

        }

        private void kömyvelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konyveles konyveles = new Konyveles(accounting);
            konyveles.Show();
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
