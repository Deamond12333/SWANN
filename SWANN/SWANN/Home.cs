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

            interval.Enabled = false;
            SWANNEnabled.Checked = true;
        }

        private void go_Click(object sender, EventArgs e)
        {
            result.Clear();
            Parser parser = new Parser();

            double[] interval = new double[2];
            if (SWANNEnabled.Checked == false)
            {
                if (!double.TryParse(a.Text, out interval[0])) throw new Exception("В поле a не число!");
                if (!double.TryParse(b.Text, out interval[1])) throw new Exception("В поле b не число!");
            }
            else interval = SWANN.getInterval(function.Text);

            double E;
         s: double L1 = interval[1] - interval[0];
            result.Text += "\r\nИнтервал: [ " + interval[0] + " ; " + interval[1] + " ]";
            if (!double.TryParse(ex.Text, out E)) throw new Exception("В поле E не число!");
            double Y = (interval[0] + interval[1] - E) / 2 + E / 2;
            double Z = (interval[0] + interval[1] - E) / 2 - E / 2;
            result.Text += "\r\nY: " + Y + " ; Z: " + Z + " ;";

            parser.Evaluate(SWANN.parseFunction(function.Text, Y));
            double y1 = parser.Result;

            parser.Evaluate(SWANN.parseFunction(function.Text, Z));
            double y2 = parser.Result;

            if (y1 <= y2) interval[1] = Z;
            else interval[0] = Y;

            double L = interval[1] - interval[0];
            if (L > L1)
            {
                result.Text += "\r\n<===========================================>\t";
                goto s;
            }
            else result.Text += "\r\nX* =  " + ((interval[0] + interval[1]) / 2) + "\r\n<=============== Конец! ===============>";

        }

        private void SWANNEnabled_CheckedChanged(object sender, EventArgs e)
        {
            interval.Enabled = !SWANNEnabled.Checked;
        }
    }
}
