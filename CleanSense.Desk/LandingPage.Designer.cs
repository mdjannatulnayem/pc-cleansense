namespace CleanSense.Desk
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.panel_back = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.core_avg = new System.Windows.Forms.TrackBar();
            this.sys_t = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.conn_status = new System.Windows.Forms.Label();
            this.btn_conn_disconn = new System.Windows.Forms.Button();
            this.port_add = new System.Windows.Forms.TextBox();
            this.logo_swd = new System.Windows.Forms.PictureBox();
            this.Clk = new System.Windows.Forms.Timer(this.components);
            this.UsbSerial = new System.IO.Ports.SerialPort(this.components);
            this.vbr_out = new System.Windows.Forms.Label();
            this.dust_out = new System.Windows.Forms.Label();
            this.smoke_out = new System.Windows.Forms.Label();
            this.mst_out = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_back.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.core_avg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_swd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_back
            // 
            this.panel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.panel_back.Controls.Add(this.panel5);
            this.panel_back.Controls.Add(this.panel4);
            this.panel_back.Controls.Add(this.panel3);
            this.panel_back.Controls.Add(this.panel1);
            this.panel_back.Controls.Add(this.panel2);
            this.panel_back.Controls.Add(this.debug);
            this.panel_back.Controls.Add(this.conn_status);
            this.panel_back.Controls.Add(this.btn_conn_disconn);
            this.panel_back.Controls.Add(this.port_add);
            this.panel_back.Controls.Add(this.logo_swd);
            this.panel_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_back.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_back.Location = new System.Drawing.Point(0, 0);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(684, 411);
            this.panel_back.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.mst_out);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(254, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 70);
            this.panel5.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Percent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Moisture";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CleanSense.Desk.Properties.Resources.humidity_icon;
            this.pictureBox4.Location = new System.Drawing.Point(359, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.smoke_out);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(254, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 70);
            this.panel4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "ppm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Smoke";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CleanSense.Desk.Properties.Resources.smoke_icon;
            this.pictureBox3.Location = new System.Drawing.Point(359, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dust_out);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(254, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 70);
            this.panel3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "(mg/L)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dust";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CleanSense.Desk.Properties.Resources.dust_icon;
            this.pictureBox2.Location = new System.Drawing.Point(359, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.vbr_out);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(254, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 70);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "(Hz)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vibration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.core_avg);
            this.panel2.Controls.Add(this.sys_t);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 150);
            this.panel2.TabIndex = 10;
            // 
            // core_avg
            // 
            this.core_avg.Location = new System.Drawing.Point(3, 41);
            this.core_avg.Maximum = 100;
            this.core_avg.Name = "core_avg";
            this.core_avg.Size = new System.Drawing.Size(208, 45);
            this.core_avg.TabIndex = 0;
            this.core_avg.TickFrequency = 10;
            // 
            // sys_t
            // 
            this.sys_t.Location = new System.Drawing.Point(3, 101);
            this.sys_t.Maximum = 100;
            this.sys_t.Name = "sys_t";
            this.sys_t.Size = new System.Drawing.Size(208, 45);
            this.sys_t.TabIndex = 7;
            this.sys_t.TickFrequency = 10;
            this.sys_t.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "System temperature";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU temperature";
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.debug.Location = new System.Drawing.Point(254, 336);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(418, 67);
            this.debug.TabIndex = 9;
            this.debug.Text = "";
            // 
            // conn_status
            // 
            this.conn_status.AutoSize = true;
            this.conn_status.Location = new System.Drawing.Point(157, 385);
            this.conn_status.Name = "conn_status";
            this.conn_status.Size = new System.Drawing.Size(91, 14);
            this.conn_status.TabIndex = 5;
            this.conn_status.Text = "Disconnected";
            // 
            // btn_conn_disconn
            // 
            this.btn_conn_disconn.Location = new System.Drawing.Point(76, 381);
            this.btn_conn_disconn.Name = "btn_conn_disconn";
            this.btn_conn_disconn.Size = new System.Drawing.Size(75, 23);
            this.btn_conn_disconn.TabIndex = 4;
            this.btn_conn_disconn.Text = "Connect";
            this.btn_conn_disconn.UseVisualStyleBackColor = true;
            this.btn_conn_disconn.Click += new System.EventHandler(this.Btn_conn_disconn_Click);
            // 
            // port_add
            // 
            this.port_add.Location = new System.Drawing.Point(10, 381);
            this.port_add.Name = "port_add";
            this.port_add.Size = new System.Drawing.Size(60, 22);
            this.port_add.TabIndex = 3;
            // 
            // logo_swd
            // 
            this.logo_swd.Image = global::CleanSense.Desk.Properties.Resources.Final_Swadheen_17;
            this.logo_swd.Location = new System.Drawing.Point(10, 336);
            this.logo_swd.Name = "logo_swd";
            this.logo_swd.Size = new System.Drawing.Size(165, 30);
            this.logo_swd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_swd.TabIndex = 0;
            this.logo_swd.TabStop = false;
            // 
            // Clk
            // 
            this.Clk.Enabled = true;
            this.Clk.Interval = 500;
            this.Clk.Tick += new System.EventHandler(this.Clk_Tick);
            // 
            // vbr_out
            // 
            this.vbr_out.AutoSize = true;
            this.vbr_out.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbr_out.Location = new System.Drawing.Point(78, 39);
            this.vbr_out.Name = "vbr_out";
            this.vbr_out.Size = new System.Drawing.Size(27, 19);
            this.vbr_out.TabIndex = 5;
            this.vbr_out.Text = "??";
            // 
            // dust_out
            // 
            this.dust_out.AutoSize = true;
            this.dust_out.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dust_out.Location = new System.Drawing.Point(78, 39);
            this.dust_out.Name = "dust_out";
            this.dust_out.Size = new System.Drawing.Size(27, 19);
            this.dust_out.TabIndex = 6;
            this.dust_out.Text = "??";
            // 
            // smoke_out
            // 
            this.smoke_out.AutoSize = true;
            this.smoke_out.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smoke_out.Location = new System.Drawing.Point(78, 39);
            this.smoke_out.Name = "smoke_out";
            this.smoke_out.Size = new System.Drawing.Size(27, 19);
            this.smoke_out.TabIndex = 6;
            this.smoke_out.Text = "??";
            // 
            // mst_out
            // 
            this.mst_out.AutoSize = true;
            this.mst_out.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mst_out.Location = new System.Drawing.Point(78, 39);
            this.mst_out.Name = "mst_out";
            this.mst_out.Size = new System.Drawing.Size(27, 19);
            this.mst_out.TabIndex = 6;
            this.mst_out.Text = "??";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.panel_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swadheen | CleanSense  v1.0";
            this.panel_back.ResumeLayout(false);
            this.panel_back.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.core_avg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sys_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_swd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.PictureBox logo_swd;
        private System.Windows.Forms.Label conn_status;
        private System.Windows.Forms.Button btn_conn_disconn;
        private System.Windows.Forms.TextBox port_add;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sys_t;
        private System.Windows.Forms.TrackBar core_avg;
        private System.Windows.Forms.Timer Clk;
        private System.IO.Ports.SerialPort UsbSerial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mst_out;
        private System.Windows.Forms.Label smoke_out;
        private System.Windows.Forms.Label dust_out;
        private System.Windows.Forms.Label vbr_out;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}