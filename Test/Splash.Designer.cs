namespace Test
{
    partial class Splash
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.versionTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CarRentTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ProgressBar);
            this.guna2GradientPanel1.Controls.Add(this.versionTitle);
            this.guna2GradientPanel1.Controls.Add(this.CarRentTitle);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(663, 371);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // versionTitle
            // 
            this.versionTitle.BackColor = System.Drawing.Color.Transparent;
            this.versionTitle.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.versionTitle.ForeColor = System.Drawing.Color.White;
            this.versionTitle.Location = new System.Drawing.Point(244, 83);
            this.versionTitle.Name = "versionTitle";
            this.versionTitle.Size = new System.Drawing.Size(173, 42);
            this.versionTitle.TabIndex = 1;
            this.versionTitle.Text = "Version 1.0";
            // 
            // CarRentTitle
            // 
            this.CarRentTitle.BackColor = System.Drawing.Color.Transparent;
            this.CarRentTitle.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.CarRentTitle.ForeColor = System.Drawing.Color.White;
            this.CarRentTitle.Location = new System.Drawing.Point(110, 12);
            this.CarRentTitle.Name = "CarRentTitle";
            this.CarRentTitle.Size = new System.Drawing.Size(420, 65);
            this.CarRentTitle.TabIndex = 0;
            this.CarRentTitle.Text = "Car Rent System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 329);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.Black;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.ProgressBar.Size = new System.Drawing.Size(639, 30);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Text = "guna2ProgressBar1";
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Text = "Splash";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel CarRentTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel versionTitle;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
    }
}