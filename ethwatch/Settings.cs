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
        public delegate void DatabaseChangeHandler(int opacity);
        public static int ops;
        public Settings(int op)
        {
            ops = op;
            InitializeComponent();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.DatabaseChanged(trackBar1.Value);
        }
    }
}
