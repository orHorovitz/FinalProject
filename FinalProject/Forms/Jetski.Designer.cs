namespace FinalProject.Forms
{
    partial class Jetski
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitleTxt = new System.Windows.Forms.Label();
            this.panelManu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJetski = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.panelManu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTitle.Controls.Add(this.lblTitleTxt);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(165, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(839, 100);
            this.pnlTitle.TabIndex = 13;
            // 
            // lblTitleTxt
            // 
            this.lblTitleTxt.AutoSize = true;
            this.lblTitleTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleTxt.Location = new System.Drawing.Point(53, 19);
            this.lblTitleTxt.Name = "lblTitleTxt";
            this.lblTitleTxt.Size = new System.Drawing.Size(137, 46);
            this.lblTitleTxt.TabIndex = 0;
            this.lblTitleTxt.Text = "Jetski";
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelManu.Controls.Add(this.btnJetski);
            this.panelManu.Controls.Add(this.btnHomePage);
            this.panelManu.Controls.Add(this.btnExit);
            this.panelManu.Controls.Add(this.panelLogo);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Margin = new System.Windows.Forms.Padding(2);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(165, 653);
            this.panelManu.TabIndex = 12;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Agency";
            // 
            // btnJetski
            // 
            this.btnJetski.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJetski.FlatAppearance.BorderSize = 0;
            this.btnJetski.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJetski.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnJetski.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJetski.Image = global::FinalProject.Properties.Resources.jet_ski_1823;
            this.btnJetski.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJetski.Location = new System.Drawing.Point(0, 65);
            this.btnJetski.Name = "btnJetski";
            this.btnJetski.Size = new System.Drawing.Size(165, 49);
            this.btnJetski.TabIndex = 7;
            this.btnJetski.Text = "Jetski";
            this.btnJetski.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJetski.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJetski.UseVisualStyleBackColor = true;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHomePage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHomePage.Image = global::FinalProject.Properties.Resources.home_2490;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 557);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(165, 49);
            this.btnHomePage.TabIndex = 6;
            this.btnHomePage.Text = " Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::FinalProject.Properties.Resources.ExitIcon32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 605);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Location = new System.Drawing.Point(190, 592);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 49);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Jetski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 653);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panelManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jetski";
            this.Text = "Jetski";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panelManu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitleTxt;
        private System.Windows.Forms.Panel panelManu;
        private System.Windows.Forms.Button btnJetski;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}