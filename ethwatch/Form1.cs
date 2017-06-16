using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using API_call;

namespace ethwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Update_nano()
        {
            string address = textBox2.Text;
            int hr = Convert.ToInt32(textBox1.Text);
            float balance = NanoPool.get_Balance(address);
            float eth_USD_Price = NanoPool.get_eth_usd_rate();
            SetText_balance_lbl(balance.ToString());
            SetText_curr_hashrate_lbl(NanoPool.get_CurrentHashrate(address).ToString());
            SetText_hashrate_1hr_lbl(NanoPool.get_Hashrate(address, 1).ToString());
            SetText_hashrate_3hr_lbl(NanoPool.get_Hashrate(address, 3).ToString());
            SetText_hashrate_6hr_lbl(NanoPool.get_Hashrate(address, 6).ToString());
            SetText_hashrate_12hr_lbl(NanoPool.get_Hashrate(address, 12).ToString());
            SetText_hashrate_24hr_lbl(NanoPool.get_Hashrate(address, 24).ToString());
            SetText_hashrate_nhr_lbl(NanoPool.get_Hashrate(address, hr).ToString());
            SetText_usd_balance_lbl(Convert.ToString(balance * eth_USD_Price));
            if (Do_ssh)
            {
                SSH.Nvidia_Info nv_info = SSH.Get_Nvidia_Info(Connection_Info);
                SetText_fan_perc_lbl(nv_info.Fan_percent.ToString() + "%");
                SetText_nv_tmp_lbl(nv_info.Temp.ToString() + "C");
                SetText_nv_pw_lbl(nv_info.Power_consumtion.ToString() + "W/" + nv_info.Power_Limit.ToString() + "W");
                SetText_nv_mem_lbl(nv_info.Mem_Usage.ToString() + "MiB/" + nv_info.Mem_Limit.ToString() + "MiB");
                SetText_nv_usage_lbl(nv_info.GPU_Util + "%");
            }
        }
        bool enabled = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                enabled = false;
                timer1.Enabled = false;
                button1.Text = "Start";
            }
            else
            {
                Thread myThread = new Thread(new ThreadStart(Update_nano));
                myThread.Start();
                timer1.Enabled = true;
                enabled = true;
                button1.Text = "Stop";
            }
        }
        private Settings frm;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) // Will call settings
        {
            frm = new Settings((int)(this.Opacity * 100), timer1.Interval, Do_ssh, Connection_Info);
            frm.DatabaseChanged += settingsForm_Databasechanged;
            frm.ShowDialog();
        }
        private static bool Do_ssh;
        private static SSH.Connection_Info Connection_Info;
        void settingsForm_Databasechanged(int op, int interval, bool ssh, SSH.Connection_Info con_Info)
        {
            this.Opacity = (double)op / 100;
            timer1.Interval = interval * 1000;
            Do_ssh = ssh;
            Connection_Info = con_Info;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(Update_nano));
            myThread.Start();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool chk = checkBox1.Checked;
            this.TopMost = chk;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #region Thread Safe Calls
        delegate void StringArgReturnVoidDelegate(string text);
        private void SetText_balance_lbl(string text)
        {
            if (this.balance_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_balance_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                balance_lbl.Text = text;
            }
        }
        private void SetText_curr_hashrate_lbl(string text)
        {
            if (this.curr_hashrate_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_curr_hashrate_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                curr_hashrate_lbl.Text = text;
            }
        }
        private void SetText_hashrate_1hr_lbl(string text)
        {
            if (this.hashrate_1hr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_1hr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_1hr_lbl.Text = text;
            }
        }
        private void SetText_hashrate_3hr_lbl(string text)
        {
            if (this.hashrate_3hr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_3hr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_3hr_lbl.Text = text;
            }
        }
        private void SetText_hashrate_6hr_lbl(string text)
        {
            if (this.hashrate_6hr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_6hr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_6hr_lbl.Text = text;
            }
        }
        private void SetText_hashrate_12hr_lbl(string text)
        {
            if (this.hashrate_12hr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_12hr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_12hr_lbl.Text = text;
            }
        }
        private void SetText_hashrate_24hr_lbl(string text)
        {
            if (this.hashrate_24hr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_24hr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_24hr_lbl.Text = text;
            }
        }
        private void SetText_hashrate_nhr_lbl(string text)
        {
            if (this.hashrate_nhr_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_hashrate_nhr_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                hashrate_nhr_lbl.Text = text;
            }
        }
        private void SetText_usd_balance_lbl(string text)
        {
            if (this.usd_balance_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_usd_balance_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                usd_balance_lbl.Text = text;
            }
        }
        private void SetText_fan_perc_lbl(string text)
        {
            if (this.fan_perc_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_fan_perc_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                fan_perc_lbl.Text = text;
            }
        }
        private void SetText_nv_tmp_lbl(string text)
        {
            if (this.nv_tmp_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_nv_tmp_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                nv_tmp_lbl.Text = text;
            }
        }
        private void SetText_nv_pw_lbl(string text)
        {
            if (this.nv_pw_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_nv_pw_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                nv_pw_lbl.Text = text;
            }
        }
        private void SetText_nv_mem_lbl(string text)
        {
            if (this.nv_mem_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_nv_mem_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                nv_mem_lbl.Text = text;
            }
        }
        private void SetText_nv_usage_lbl(string text)
        {
            if (this.nv_usage_lbl.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_nv_usage_lbl);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                nv_usage_lbl.Text = text;
            }
        }
        #endregion
    }
}
