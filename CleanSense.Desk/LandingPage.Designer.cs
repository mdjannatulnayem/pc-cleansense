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
            this.panel_back = new System.Windows.Forms.Panel();
            this.conn_status = new System.Windows.Forms.Label();
            this.btn_conn_disconn = new System.Windows.Forms.Button();
            this.port_addr = new System.Windows.Forms.TextBox();
            this.logo_swd = new System.Windows.Forms.PictureBox();
            this.panel_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_swd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_back
            // 
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
            this.conn_status.Location = new System.Drawing.Point(157, 54);
            this.conn_status.Name = "conn_status";
            this.conn_status.Size = new System.Drawing.Size(91, 14);
            this.conn_status.TabIndex = 5;
            this.conn_status.Text = "Disconnected";
            // 
            // btn_conn_disconn
            // 
            this.btn_conn_disconn.Location = new System.Drawing.Point(76, 50);
            this.btn_conn_disconn.Name = "btn_conn_disconn";
            this.btn_conn_disconn.Size = new System.Drawing.Size(75, 23);
            this.btn_conn_disconn.TabIndex = 4;
            this.btn_conn_disconn.Text = "Connect";
            this.btn_conn_disconn.UseVisualStyleBackColor = true;
            // 
            // port_addr
            // 
            this.port_addr.Location = new System.Drawing.Point(10, 50);
            this.port_addr.Name = "port_addr";
            this.port_addr.Size = new System.Drawing.Size(60, 22);
            this.port_addr.TabIndex = 3;
            // 
            // logo_swd
            // 
            this.logo_swd.Image = global::CleanSense.Desk.Properties.Resources.Final_Swadheen_17;
            this.logo_swd.Location = new System.Drawing.Point(10, 5);
            this.logo_swd.Name = "logo_swd";
            this.logo_swd.Size = new System.Drawing.Size(160, 30);
            this.logo_swd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_swd.TabIndex = 0;
            this.logo_swd.TabStop = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.PictureBox logo_swd;
        private System.Windows.Forms.Label conn_status;
        private System.Windows.Forms.Button btn_conn_disconn;
        private System.Windows.Forms.TextBox port_addr;
    }
}