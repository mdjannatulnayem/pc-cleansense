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
            this.panel_back = new System.Windows.Forms.Panel();
            this.conn_status = new System.Windows.Forms.Label();
            this.btn_conn_disconn = new System.Windows.Forms.Button();
            this.port_addr = new System.Windows.Forms.TextBox();
            this.logo_swd = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.TIME = new System.Windows.Forms.Timer(this.components);
            this.PORT = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_swd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_back
            // 
            this.panel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.panel_back.Controls.Add(this.panel2);
            this.panel_back.Controls.Add(this.debug);
            this.panel_back.Controls.Add(this.conn_status);
            this.panel_back.Controls.Add(this.btn_conn_disconn);
            this.panel_back.Controls.Add(this.port_addr);
            this.panel_back.Controls.Add(this.logo_swd);
            this.panel_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_back.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_back.Location = new System.Drawing.Point(0, 0);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(684, 411);
            this.panel_back.TabIndex = 0;
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
            this.btn_conn_disconn.Click += new System.EventHandler(this.btn_conn_disconn_Click);
            // 
            // port_addr
            // 
            this.port_addr.Location = new System.Drawing.Point(10, 381);
            this.port_addr.Name = "port_addr";
            this.port_addr.Size = new System.Drawing.Size(60, 22);
            this.port_addr.TabIndex = 3;
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 41);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(3, 101);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(208, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU temperature";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "System temperature";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 150);
            this.panel2.TabIndex = 10;
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
            ((System.ComponentModel.ISupportInitialize)(this.logo_swd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.PictureBox logo_swd;
        private System.Windows.Forms.Label conn_status;
        private System.Windows.Forms.Button btn_conn_disconn;
        private System.Windows.Forms.TextBox port_addr;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer TIME;
        private System.IO.Ports.SerialPort PORT;
        private System.Windows.Forms.Panel panel2;
    }
}