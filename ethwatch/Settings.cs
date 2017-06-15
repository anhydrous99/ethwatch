using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ethwatch
{
    public partial class Settings : Form
    {
        public event DatabaseChangeHandler DatabaseChanged;
        public delegate void DatabaseChangeHandler(int opacity, bool enable_time, int interval);
        public Settings(int op, bool is_checked, int interval)
        {
            InitializeComponent();
            trackBar1.Value = op;
            checkBox1.Checked = is_checked;
            textBox1.Text = Convert.ToString(interval / 1000);
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.DatabaseChanged(trackBar1.Value, checkBox1.Checked, Convert.ToInt32(textBox1.Text));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
            this.DatabaseChanged(trackBar1.Value, checkBox1.Checked, Convert.ToInt32(textBox1.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.DatabaseChanged(trackBar1.Value, checkBox1.Checked, Convert.ToInt32(textBox1.Text));
        }
    }
}
