
namespace FinalProject.Forms
{
    partial class HomePage
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
            this.panelManu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitleTxt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAllvehicles = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnMotorcycle = new System.Windows.Forms.Button();
            this.btnShips = new System.Windows.Forms.Button();
            this.panelManu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelManu.Controls.Add(this.btnExit);
            this.panelManu.Controls.Add(this.btnAllvehicles);
            this.panelManu.Controls.Add(this.btnCars);
            this.panelManu.Controls.Add(this.btnMotorcycle);
            this.panelManu.Controls.Add(this.btnShips);
            this.panelManu.Controls.Add(this.panelLogo);
            this.panelManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Margin = new System.Windows.Forms.Padding(2);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(165, 653);
            this.panelManu.TabIndex = 0;
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
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTitle.Controls.Add(this.lblTitleTxt);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(165, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(839, 100);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitleTxt
            // 
            this.lblTitleTxt.AutoSize = true;
            this.lblTitleTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleTxt.Location = new System.Drawing.Point(26, 19);
            this.lblTitleTxt.Name = "lblTitleTxt";
            this.lblTitleTxt.Size = new System.Drawing.Size(267, 46);
            this.lblTitleTxt.TabIndex = 0;
            this.lblTitleTxt.Text = "HOME PAGE";
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
            this.btnAllvehicles.Image = global::FinalProject.Properties.Resources.AllCars32;
            this.btnAllvehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllvehicles.Location = new System.Drawing.Point(0, 65);
            this.btnAllvehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllvehicles.Name = "btnAllvehicles";
            this.btnAllvehicles.Size = new System.Drawing.Size(165, 49);
            this.btnAllvehicles.TabIndex = 1;
            this.btnAllvehicles.Text = "  All Vehicles ";
            this.btnAllvehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllvehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllvehicles.UseVisualStyleBackColor = true;
            this.btnAllvehicles.Click += new System.EventHandler(this.btnAllvehicles_Click_1);
            // 
            // btnCars
            // 
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCars.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCars.Image = global::FinalProject.Properties.Resources.Cars32;
            this.btnCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCars.Location = new System.Drawing.Point(0, 212);
            this.btnCars.Margin = new System.Windows.Forms.Padding(2);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(165, 49);
            this.btnCars.TabIndex = 4;
            this.btnCars.Text = "  Cars";
            this.btnCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnMotorcycle
            // 
            this.btnMotorcycle.FlatAppearance.BorderSize = 0;
            this.btnMotorcycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotorcycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorcycle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotorcycle.Image = global::FinalProject.Properties.Resources.motorcycle32;
            this.btnMotorcycle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorcycle.Location = new System.Drawing.Point(0, 163);
            this.btnMotorcycle.Margin = new System.Windows.Forms.Padding(2);
            this.btnMotorcycle.Name = "btnMotorcycle";
            this.btnMotorcycle.Size = new System.Drawing.Size(165, 49);
            this.btnMotorcycle.TabIndex = 3;
            this.btnMotorcycle.Text = "  Motorcycle";
            this.btnMotorcycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorcycle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotorcycle.UseVisualStyleBackColor = true;
            this.btnMotorcycle.Click += new System.EventHandler(this.btnMotorcycle_Click);
            // 
            // btnShips
            // 
            this.btnShips.FlatAppearance.BorderSize = 0;
            this.btnShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShips.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShips.Image = global::FinalProject.Properties.Resources.cruise_1042;
            this.btnShips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShips.Location = new System.Drawing.Point(0, 114);
            this.btnShips.Margin = new System.Windows.Forms.Padding(2);
            this.btnShips.Name = "btnShips";
            this.btnShips.Size = new System.Drawing.Size(165, 49);
            this.btnShips.TabIndex = 2;
            this.btnShips.Text = " Ships";
            this.btnShips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShips.UseVisualStyleBackColor = true;
            this.btnShips.Click += new System.EventHandler(this.btnShips_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 653);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panelManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.Text = "MainMenu";
            this.panelManu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManu;
        private System.Windows.Forms.Button btnAllvehicles;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnMotorcycle;
        private System.Windows.Forms.Button btnShips;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitleTxt;
    }
}