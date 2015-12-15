using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWANN
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SWANN swann = new SWANN();
            label1.Text = swann.parseFunction(textBox1.Text, 2.0, 0).ToString();
        }
    }
}
