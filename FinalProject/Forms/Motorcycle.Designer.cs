﻿namespace FinalProject.Forms
{
    partial class Motorcycle
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
            this.btnBikes = new System.Windows.Forms.Button();
            this.btnATV = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAllvehicles = new System.Windows.Forms.Button();
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
            this.pnlTitle.TabIndex = 5;
            // 
            // lblTitleTxt
            // 
            this.lblTitleTxt.AutoSize = true;
            this.lblTitleTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleTxt.Location = new System.Drawing.Point(34, 19);
            this.lblTitleTxt.Name = "lblTitleTxt";
            this.lblTitleTxt.Size = new System.Drawing.Size(304, 46);
            this.lblTitleTxt.TabIndex = 0;
            this.lblTitleTxt.Text = "ATV and Bikes";
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelManu.Controls.Add(this.btnBikes);
            this.panelManu.Controls.Add(this.btnATV);
            this.panelManu.Controls.Add(this.btnHomePage);
            this.panelManu.Controls.Add(this.btnExit);
            this.panelManu.Controls.Add(this.btnAllvehicles);
            this.panelManu.Controls.Add(this.panelLogo);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Margin = new System.Windows.Forms.Padding(2);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(165, 653);
            this.panelManu.TabIndex = 4;
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
            // btnBikes
            // 
            this.btnBikes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBikes.FlatAppearance.BorderSize = 0;
            this.btnBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBikes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBikes.Image = global::FinalProject.Properties.Resources.motorcycle32;
            this.btnBikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBikes.Location = new System.Drawing.Point(0, 163);
            this.btnBikes.Name = "btnBikes";
            this.btnBikes.Size = new System.Drawing.Size(165, 49);
            this.btnBikes.TabIndex = 8;
            this.btnBikes.Text = " Bikes";
            this.btnBikes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBikes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBikes.UseVisualStyleBackColor = true;
            this.btnBikes.Click += new System.EventHandler(this.btnBikes_Click);
            // 
            // btnATV
            // 
            this.btnATV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnATV.FlatAppearance.BorderSize = 0;
            this.btnATV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnATV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnATV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnATV.Image = global::FinalProject.Properties.Resources.car_2900;
            this.btnATV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnATV.Location = new System.Drawing.Point(0, 114);
            this.btnATV.Name = "btnATV";
            this.btnATV.Size = new System.Drawing.Size(165, 49);
            this.btnATV.TabIndex = 7;
            this.btnATV.Text = " ATV";
            this.btnATV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnATV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnATV.UseVisualStyleBackColor = true;
            this.btnATV.Click += new System.EventHandler(this.btnATV_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
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
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnAllvehicles
            // 
            this.btnAllvehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllvehicles.FlatAppearance.BorderSize = 0;
            this.btnAllvehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllvehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllvehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllvehicles.Image = global::FinalProject.Properties.Resources.scooter_1041;
            this.btnAllvehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllvehicles.Location = new System.Drawing.Point(0, 65);
            this.btnAllvehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllvehicles.Name = "btnAllvehicles";
            this.btnAllvehicles.Size = new System.Drawing.Size(165, 49);
            this.btnAllvehicles.TabIndex = 1;
            this.btnAllvehicles.Text = "Motorcycle";
            this.btnAllvehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllvehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllvehicles.UseVisualStyleBackColor = true;
            // 
            // Motorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 653);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panelManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Motorcycle";
            this.Text = "Motorcycle";
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
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAllvehicles;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBikes;
        private System.Windows.Forms.Button btnATV;
    }
}