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
        public delegate void DatabaseChangeHandler(int opacity, int interval);
        public Settings(int op, int interval)
        {
            InitializeComponent();
            trackBar1.Value = op;
            textBox1.Text = Convert.ToString(interval / 1000);
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.DatabaseChanged(trackBar1.Value, Convert.ToInt32(textBox1.Text));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.DatabaseChanged(trackBar1.Value, Convert.ToInt32(textBox1.Text));
        }
    }
}
