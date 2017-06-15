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
            label10.Text = balance.ToString();
            label11.Text = NanoPool.get_CurrentHashrate(address).ToString();
            label12.Text = NanoPool.get_Hashrate(address, 1).ToString();
            label13.Text = NanoPool.get_Hashrate(address, 3).ToString();
            label14.Text = NanoPool.get_Hashrate(address, 6).ToString();
            label15.Text = NanoPool.get_Hashrate(address, 12).ToString();
            label16.Text = NanoPool.get_Hashrate(address, 24).ToString();
            label17.Text = NanoPool.get_Hashrate(address, hr).ToString();
            label24.Text = Convert.ToString(balance * eth_USD_Price);
            if (Do_ssh)
            {
                SSH.Nvidia_Info nv_info = SSH.Get_Nvidia_Info(Connection_Info);
                label25.Text = nv_info.Fan_percent.ToString() + "%";
                label26.Text = nv_info.Temp.ToString() + "C";
                label27.Text = nv_info.Power_consumtion.ToString() + "W/" + nv_info.Power_Limit.ToString() + "W";
                label28.Text = nv_info.Mem_Usage.ToString() + "MiB/" + nv_info.Mem_Limit.ToString() + "MiB";
                label29.Text = nv_info.GPU_Util + "%";
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
                Update_nano();
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
            System.Threading.Thread myThread = new System.Threading.Thread(new System.Threading.ThreadStart(Update_nano));
            myThread.Start();
        }
    }
}
