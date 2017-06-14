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
            label10.Text = NanoPool.get_Balance(address).ToString();
            label11.Text = NanoPool.get_CurrentHashrate(address).ToString();
            label12.Text = NanoPool.get_Hashrate(address, 1).ToString();
            label13.Text = NanoPool.get_Hashrate(address, 3).ToString();
            label14.Text = NanoPool.get_Hashrate(address, 6).ToString();
            label15.Text = NanoPool.get_Hashrate(address, 12).ToString();
            label16.Text = NanoPool.get_Hashrate(address, 24).ToString();
            label17.Text = NanoPool.get_Hashrate(address, hr).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Update_nano();
        }
        private Settings frm;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) // Will call settings
        {
            frm = new Settings((int)(this.Opacity * 100));
            frm.DatabaseChanged += settingsForm_Databasechanged;
            frm.ShowDialog();
        }
        void settingsForm_Databasechanged(int op)
        {
            this.Opacity = (double)op / 100;
        }
    }
}
