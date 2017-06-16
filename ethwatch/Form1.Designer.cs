namespace ethwatch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usd_balance_lbl = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hashrate_nhr_lbl = new System.Windows.Forms.Label();
            this.hashrate_24hr_lbl = new System.Windows.Forms.Label();
            this.hashrate_12hr_lbl = new System.Windows.Forms.Label();
            this.hashrate_6hr_lbl = new System.Windows.Forms.Label();
            this.hashrate_3hr_lbl = new System.Windows.Forms.Label();
            this.hashrate_1hr_lbl = new System.Windows.Forms.Label();
            this.curr_hashrate_lbl = new System.Windows.Forms.Label();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nv_usage_lbl = new System.Windows.Forms.Label();
            this.nv_mem_lbl = new System.Windows.Forms.Label();
            this.nv_pw_lbl = new System.Windows.Forms.Label();
            this.nv_tmp_lbl = new System.Windows.Forms.Label();
            this.fan_perc_lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.usd_balance_lbl);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.hashrate_nhr_lbl);
            this.groupBox1.Controls.Add(this.hashrate_24hr_lbl);
            this.groupBox1.Controls.Add(this.hashrate_12hr_lbl);
            this.groupBox1.Controls.Add(this.hashrate_6hr_lbl);
            this.groupBox1.Controls.Add(this.hashrate_3hr_lbl);
            this.groupBox1.Controls.Add(this.hashrate_1hr_lbl);
            this.groupBox1.Controls.Add(this.curr_hashrate_lbl);
            this.groupBox1.Controls.Add(this.balance_lbl);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info (NanoPool)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Always Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // usd_balance_lbl
            // 
            this.usd_balance_lbl.AutoSize = true;
            this.usd_balance_lbl.Location = new System.Drawing.Point(99, 136);
            this.usd_balance_lbl.Name = "usd_balance_lbl";
            this.usd_balance_lbl.Size = new System.Drawing.Size(13, 13);
            this.usd_balance_lbl.TabIndex = 10;
            this.usd_balance_lbl.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "USD Balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // hashrate_nhr_lbl
            // 
            this.hashrate_nhr_lbl.AutoSize = true;
            this.hashrate_nhr_lbl.Location = new System.Drawing.Point(99, 123);
            this.hashrate_nhr_lbl.Name = "hashrate_nhr_lbl";
            this.hashrate_nhr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_nhr_lbl.TabIndex = 1;
            this.hashrate_nhr_lbl.Text = "0";
            // 
            // hashrate_24hr_lbl
            // 
            this.hashrate_24hr_lbl.AutoSize = true;
            this.hashrate_24hr_lbl.Location = new System.Drawing.Point(99, 107);
            this.hashrate_24hr_lbl.Name = "hashrate_24hr_lbl";
            this.hashrate_24hr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_24hr_lbl.TabIndex = 1;
            this.hashrate_24hr_lbl.Text = "0";
            // 
            // hashrate_12hr_lbl
            // 
            this.hashrate_12hr_lbl.AutoSize = true;
            this.hashrate_12hr_lbl.Location = new System.Drawing.Point(99, 94);
            this.hashrate_12hr_lbl.Name = "hashrate_12hr_lbl";
            this.hashrate_12hr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_12hr_lbl.TabIndex = 1;
            this.hashrate_12hr_lbl.Text = "0";
            // 
            // hashrate_6hr_lbl
            // 
            this.hashrate_6hr_lbl.AutoSize = true;
            this.hashrate_6hr_lbl.Location = new System.Drawing.Point(99, 81);
            this.hashrate_6hr_lbl.Name = "hashrate_6hr_lbl";
            this.hashrate_6hr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_6hr_lbl.TabIndex = 1;
            this.hashrate_6hr_lbl.Text = "0";
            // 
            // hashrate_3hr_lbl
            // 
            this.hashrate_3hr_lbl.AutoSize = true;
            this.hashrate_3hr_lbl.Location = new System.Drawing.Point(99, 68);
            this.hashrate_3hr_lbl.Name = "hashrate_3hr_lbl";
            this.hashrate_3hr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_3hr_lbl.TabIndex = 1;
            this.hashrate_3hr_lbl.Text = "0";
            // 
            // hashrate_1hr_lbl
            // 
            this.hashrate_1hr_lbl.AutoSize = true;
            this.hashrate_1hr_lbl.Location = new System.Drawing.Point(99, 55);
            this.hashrate_1hr_lbl.Name = "hashrate_1hr_lbl";
            this.hashrate_1hr_lbl.Size = new System.Drawing.Size(13, 13);
            this.hashrate_1hr_lbl.TabIndex = 1;
            this.hashrate_1hr_lbl.Text = "0";
            // 
            // curr_hashrate_lbl
            // 
            this.curr_hashrate_lbl.AutoSize = true;
            this.curr_hashrate_lbl.Location = new System.Drawing.Point(99, 42);
            this.curr_hashrate_lbl.Name = "curr_hashrate_lbl";
            this.curr_hashrate_lbl.Size = new System.Drawing.Size(13, 13);
            this.curr_hashrate_lbl.TabIndex = 8;
            this.curr_hashrate_lbl.Text = "0";
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Location = new System.Drawing.Point(99, 29);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(13, 13);
            this.balance_lbl.TabIndex = 7;
            this.balance_lbl.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ethwatch.Properties.Settings.Default, "lol", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(9, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = global::ethwatch.Properties.Settings.Default.lol;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "hr avg";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(9, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "48";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "24 hr avg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "12 hr avg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "6 hr avg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3 hr avg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1 hr avg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Hashrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance(int)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nv_usage_lbl);
            this.groupBox2.Controls.Add(this.nv_mem_lbl);
            this.groupBox2.Controls.Add(this.nv_pw_lbl);
            this.groupBox2.Controls.Add(this.nv_tmp_lbl);
            this.groupBox2.Controls.Add(this.fan_perc_lbl);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nvidia Info";
            // 
            // nv_usage_lbl
            // 
            this.nv_usage_lbl.AutoSize = true;
            this.nv_usage_lbl.Location = new System.Drawing.Point(55, 68);
            this.nv_usage_lbl.Name = "nv_usage_lbl";
            this.nv_usage_lbl.Size = new System.Drawing.Size(13, 13);
            this.nv_usage_lbl.TabIndex = 8;
            this.nv_usage_lbl.Text = "0";
            // 
            // nv_mem_lbl
            // 
            this.nv_mem_lbl.AutoSize = true;
            this.nv_mem_lbl.Location = new System.Drawing.Point(55, 55);
            this.nv_mem_lbl.Name = "nv_mem_lbl";
            this.nv_mem_lbl.Size = new System.Drawing.Size(13, 13);
            this.nv_mem_lbl.TabIndex = 7;
            this.nv_mem_lbl.Text = "0";
            // 
            // nv_pw_lbl
            // 
            this.nv_pw_lbl.AutoSize = true;
            this.nv_pw_lbl.Location = new System.Drawing.Point(55, 42);
            this.nv_pw_lbl.Name = "nv_pw_lbl";
            this.nv_pw_lbl.Size = new System.Drawing.Size(13, 13);
            this.nv_pw_lbl.TabIndex = 6;
            this.nv_pw_lbl.Text = "0";
            // 
            // nv_tmp_lbl
            // 
            this.nv_tmp_lbl.AutoSize = true;
            this.nv_tmp_lbl.Location = new System.Drawing.Point(55, 29);
            this.nv_tmp_lbl.Name = "nv_tmp_lbl";
            this.nv_tmp_lbl.Size = new System.Drawing.Size(13, 13);
            this.nv_tmp_lbl.TabIndex = 5;
            this.nv_tmp_lbl.Text = "0";
            // 
            // fan_perc_lbl
            // 
            this.fan_perc_lbl.AutoSize = true;
            this.fan_perc_lbl.Location = new System.Drawing.Point(55, 16);
            this.fan_perc_lbl.Name = "fan_perc_lbl";
            this.fan_perc_lbl.Size = new System.Drawing.Size(13, 13);
            this.fan_perc_lbl.TabIndex = 4;
            this.fan_perc_lbl.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Usage";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Mem.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Pow.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Temp.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Fan";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::ethwatch.Properties.Settings.Default, "lol2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = global::ethwatch.Properties.Settings.Default.lol2;
            this.Text = "ethwatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hashrate_nhr_lbl;
        private System.Windows.Forms.Label hashrate_24hr_lbl;
        private System.Windows.Forms.Label hashrate_12hr_lbl;
        private System.Windows.Forms.Label hashrate_6hr_lbl;
        private System.Windows.Forms.Label hashrate_3hr_lbl;
        private System.Windows.Forms.Label hashrate_1hr_lbl;
        private System.Windows.Forms.Label curr_hashrate_lbl;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label usd_balance_lbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label nv_usage_lbl;
        private System.Windows.Forms.Label nv_mem_lbl;
        private System.Windows.Forms.Label nv_pw_lbl;
        private System.Windows.Forms.Label nv_tmp_lbl;
        private System.Windows.Forms.Label fan_perc_lbl;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

