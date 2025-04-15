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
    public partial class Nevjegy: Form
    {
        public Nevjegy()
        {
            InitializeComponent();
            this.labelDateTime.Text = System.DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
