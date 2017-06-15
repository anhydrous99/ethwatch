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
            float eth_BTC_Price = NanoPool.get_eth_btc_rate();
            SetText_label10(balance.ToString());
            SetText_label11(NanoPool.get_CurrentHashrate(address).ToString());
            SetText_label12(NanoPool.get_Hashrate(address, 1).ToString());
            SetText_label13(NanoPool.get_Hashrate(address, 3).ToString());
            SetText_label14(NanoPool.get_Hashrate(address, 6).ToString());
            SetText_label15(NanoPool.get_Hashrate(address, 12).ToString());
            SetText_label16(NanoPool.get_Hashrate(address, 24).ToString());
            SetText_label17(NanoPool.get_Hashrate(address, hr).ToString());
            SetText_label24(Convert.ToString(balance * eth_USD_Price));
            if (Do_ssh)
            {
                SSH.Nvidia_Info nv_info = SSH.Get_Nvidia_Info(Connection_Info);
                SetText_label25(nv_info.Fan_percent.ToString() + "%");
                SetText_label26(nv_info.Temp.ToString() + "C");
                SetText_label27(nv_info.Power_consumtion.ToString() + "W/" + nv_info.Power_Limit.ToString() + "W");
                SetText_label28(nv_info.Mem_Usage.ToString() + "MiB/" + nv_info.Mem_Limit.ToString() + "MiB");
                SetText_label29(nv_info.GPU_Util + "%");
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
        private static bool Do_ssh = false;
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
            TopMost = chk;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #region Thread Safe Calls
        delegate void StringArgReturnVoidDelegate(string text);
        private void SetText_label10(string text)
        {
            if (this.label10.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label10);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label10.Text = text;
            }
        }
        private void SetText_label11(string text)
        {
            if (this.label11.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label11);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label11.Text = text;
            }
        }
        private void SetText_label12(string text)
        {
            if (this.label12.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label12);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label12.Text = text;
            }
        }
        private void SetText_label13(string text)
        {
            if (this.label13.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label13);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label13.Text = text;
            }
        }
        private void SetText_label14(string text)
        {
            if (this.label14.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label14);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label14.Text = text;
            }
        }
        private void SetText_label15(string text)
        {
            if (this.label15.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label15);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label15.Text = text;
            }
        }
        private void SetText_label16(string text)
        {
            if (this.label16.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label16);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label16.Text = text;
            }
        }
        private void SetText_label17(string text)
        {
            if (this.label17.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label17);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label17.Text = text;
            }
        }
        private void SetText_label24(string text)
        {
            if (this.label24.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label24);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label24.Text = text;
            }
        }
        private void SetText_label25(string text)
        {
            if (this.label25.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label25);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label25.Text = text;
            }
        }
        private void SetText_label26(string text)
        {
            if (this.label26.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label26);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label26.Text = text;
            }
        }
        private void SetText_label27(string text)
        {
            if (this.label27.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label27);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label27.Text = text;
            }
        }
        private void SetText_label28(string text)
        {
            if (this.label28.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label28);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label28.Text = text;
            }
        }
        private void SetText_label29(string text)
        {
            if (this.label29.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = new StringArgReturnVoidDelegate(SetText_label29);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                label29.Text = text;
            }
        }
        #endregion
    }
}
