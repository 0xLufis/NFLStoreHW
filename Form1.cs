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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace S0IPAF
{
    public partial class Form1 : Form
    {
        private string SourceDataFilePath;
        private void SetSourceDataFilePath(string FName)
        {
            this.SourceDataFilePath = FName;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
            "Text (*.txt)|*.txt|" + "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SetSourceDataFilePath(openFileDialog1.FileName);
            Application.DoEvents();
        }
    }
}
