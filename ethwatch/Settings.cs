using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_call;

namespace ethwatch
{
    public partial class Settings : Form
    {
        public event DatabaseChangeHandler DatabaseChanged;
        public delegate void DatabaseChangeHandler(int opacity, int interval, bool ssh, SSH.Connection_Info con_Info);
        private static SSH.Connection_Info _Connection_Info;
        private static bool Do_ssh = false;
        public Settings(int op, int interval, bool do_ssh, SSH.Connection_Info con_info)
        {
            InitializeComponent();
            trackBar1.Value = op;
            textBox1.Text = Convert.ToString(interval / 1000);
            if (do_ssh)
            {
                give_Connection_Info(con_info);
            }
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            pass_txt.TextChanged += new System.EventHandler(_TextChanged);
            user_txt.TextChanged += new System.EventHandler(_TextChanged);
            add_txt.TextChanged += new System.EventHandler(_TextChanged);
            prt_txt.TextChanged += new System.EventHandler(_TextChanged);
            checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            DatabaseChanged(trackBar1.Value, Convert.ToInt32(textBox1.Text), Do_ssh, _Connection_Info);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DatabaseChanged(trackBar1.Value, Convert.ToInt32(textBox1.Text), Do_ssh, _Connection_Info);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = checkBox1.Checked;
            add_txt.Enabled = chk;
            user_txt.Enabled = chk;
            pass_txt.Enabled = chk;
            prt_txt.Enabled = chk;
            Do_ssh = chk;
        }
        private void _TextChanged(object sender, EventArgs e)
        {
            _Connection_Info = asdf_Connection_Info();
            DatabaseChanged(trackBar1.Value, Convert.ToInt32(textBox1.Text), Do_ssh, _Connection_Info);
        }
        private SSH.Connection_Info asdf_Connection_Info()
        {
            return new SSH.Connection_Info(user_txt.Text,pass_txt.Text,add_txt.Text,Convert.ToInt32(prt_txt.Text));
        }
        private void give_Connection_Info(SSH.Connection_Info con_info)
        {
            
            add_txt.Text = con_info.Address;
            user_txt.Text = con_info.Username;
            prt_txt.Text = con_info.Port.ToString();
            pass_txt.Text = con_info.Password;
            checkBox1.Checked = true;
            add_txt.Enabled = true;
            user_txt.Enabled = true;
            pass_txt.Enabled = true;
            prt_txt.Enabled = true;
        }
    }
}
