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
        public event DatabaseChangeHandler_1 DatabaseChanged_1;
        public event DatabaseChangeHandler_2 DatabaseChanged_2;
        public event DatabaseChangeHandler_3 DatabaseChanged_3;
        public delegate void DatabaseChangeHandler_1(int opacity);
        public delegate void DatabaseChangeHandler_2(bool ssh, SSH.Connection_Info con_Info);
        public delegate void DatabaseChangeHandler_3(int interval);
        private static bool Do_ssh;

        public Settings(int op, int interval, bool do_ssh, SSH.Connection_Info con_info)
        {
            InitializeComponent();
            trackBar1.Value = op;
            Interval_txt_box.Text = Convert.ToString(interval / 1000);
            if (do_ssh)
            {
                give_Connection_Info(con_info);
            }
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseChanged_2(Do_ssh, Connection_Info());
            }
            catch(ArgumentException ex)
            {
                prt_txt.Text = "22";
                MessageBox.Show(ex.Message);
            }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            DatabaseChanged_1(trackBar1.Value);
        }
        private void Interval_txt_box_TextChanged(object sender, EventArgs e)
        {
            int inter_phrased;
            if (!int.TryParse(Interval_txt_box.Text, out inter_phrased) && Interval_txt_box.Text != "")
            {
                MessageBox.Show("Please enter a number as the interval.");
                return;
            }
            else if (Interval_txt_box.Text == String.Empty)
            {
                inter_phrased = 30;
            }
            DatabaseChanged_3(inter_phrased);
        }
        private SSH.Connection_Info Connection_Info()
        {
            int prt = 0;
            if (!int.TryParse(prt_txt.Text, out prt) && prt_txt.Text != "")
            {
                throw new System.ArgumentException("Entered non-Number as port number.","Port Number");
            }
            else if (prt_txt.Text == "")
            {
                prt = 22;
            }
            return new SSH.Connection_Info(user_txt.Text, pass_txt.Text, add_txt.Text, prt);
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
            Do_ssh = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = checkBox1.Checked;
            add_txt.Enabled = chk;
            user_txt.Enabled = chk;
            prt_txt.Enabled = chk;
            pass_txt.Enabled = chk;
            Submit.Enabled = chk;
            Do_ssh = chk;
        }
    }
}
