namespace Test
{
    partial class MainPage
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
            this.panelSideManu = new System.Windows.Forms.Panel();
            this.btnAllVehicles = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.AutoRentLogo = new System.Windows.Forms.Label();
            this.ChildFormpanel = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMotorcycle = new System.Windows.Forms.Button();
            this.btnShips = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.panelSideManu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideManu
            // 
            this.panelSideManu.AutoScroll = true;
            this.panelSideManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panelSideManu.Controls.Add(this.btnHomePage);
            this.panelSideManu.Controls.Add(this.btnExit);
            this.panelSideManu.Controls.Add(this.btnAllVehicles);
            this.panelSideManu.Controls.Add(this.btnMotorcycle);
            this.panelSideManu.Controls.Add(this.btnShips);
            this.panelSideManu.Controls.Add(this.btnCar);
            this.panelSideManu.Controls.Add(this.panelLogo);
            this.panelSideManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideManu.Location = new System.Drawing.Point(0, 0);
            this.panelSideManu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideManu.Name = "panelSideManu";
            this.panelSideManu.Size = new System.Drawing.Size(267, 840);
            this.panelSideManu.TabIndex = 0;
            // 
            // btnAllVehicles
            // 
            this.btnAllVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllVehicles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAllVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllVehicles.Location = new System.Drawing.Point(0, 288);
            this.btnAllVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllVehicles.Name = "btnAllVehicles";
            this.btnAllVehicles.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAllVehicles.Size = new System.Drawing.Size(267, 55);
            this.btnAllVehicles.TabIndex = 7;
            this.btnAllVehicles.Text = "All Vehicles";
            this.btnAllVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllVehicles.UseVisualStyleBackColor = true;
            this.btnAllVehicles.Click += new System.EventHandler(this.btnAllVehicles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.AutoRentLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(267, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // AutoRentLogo
            // 
            this.AutoRentLogo.AutoSize = true;
            this.AutoRentLogo.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRentLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.AutoRentLogo.Location = new System.Drawing.Point(16, 46);
            this.AutoRentLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutoRentLogo.Name = "AutoRentLogo";
            this.AutoRentLogo.Size = new System.Drawing.Size(200, 30);
            this.AutoRentLogo.TabIndex = 0;
            this.AutoRentLogo.Text = "Vehicles Rent";
            // 
            // ChildFormpanel
            // 
            this.ChildFormpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChildFormpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormpanel.Location = new System.Drawing.Point(267, 0);
            this.ChildFormpanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChildFormpanel.Name = "ChildFormpanel";
            this.ChildFormpanel.Size = new System.Drawing.Size(1443, 840);
            this.ChildFormpanel.TabIndex = 1;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.ForeColor = System.Drawing.Color.LightGray;
            this.btnHomePage.Image = global::Test.Properties.Resources.home_2490;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 730);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHomePage.Size = new System.Drawing.Size(267, 55);
            this.btnHomePage.TabIndex = 9;
            this.btnHomePage.Text = "Home page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::Test.Properties.Resources.exit_logout_2857;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 785);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(267, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMotorcycle
            // 
            this.btnMotorcycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMotorcycle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMotorcycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotorcycle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMotorcycle.Image = global::Test.Properties.Resources.scooter_1041;
            this.btnMotorcycle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorcycle.Location = new System.Drawing.Point(0, 233);
            this.btnMotorcycle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotorcycle.Name = "btnMotorcycle";
            this.btnMotorcycle.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMotorcycle.Size = new System.Drawing.Size(267, 55);
            this.btnMotorcycle.TabIndex = 5;
            this.btnMotorcycle.Text = "Motorcycle";
            this.btnMotorcycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMotorcycle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotorcycle.UseVisualStyleBackColor = true;
            this.btnMotorcycle.Click += new System.EventHandler(this.btnMotorcycle_Click);
            // 
            // btnShips
            // 
            this.btnShips.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShips.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShips.Image = global::Test.Properties.Resources.cruise_1042;
            this.btnShips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShips.Location = new System.Drawing.Point(0, 178);
            this.btnShips.Margin = new System.Windows.Forms.Padding(4);
            this.btnShips.Name = "btnShips";
            this.btnShips.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnShips.Size = new System.Drawing.Size(267, 55);
            this.btnShips.TabIndex = 3;
            this.btnShips.Text = "Ships";
            this.btnShips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShips.UseVisualStyleBackColor = true;
            this.btnShips.Click += new System.EventHandler(this.btnShips_Click);
            // 
            // btnCar
            // 
            this.btnCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCar.Image = global::Test.Properties.Resources.car_4760;
            this.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.Location = new System.Drawing.Point(0, 123);
            this.btnCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCar.Name = "btnCar";
            this.btnCar.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnCar.Size = new System.Drawing.Size(267, 55);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "Cars";
            this.btnCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.ChildFormpanel);
            this.Controls.Add(this.panelSideManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1707, 824);
            this.Name = "MainPage";
            this.Text = "Rent A Vehicles Application";
            this.panelSideManu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideManu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAllVehicles;
        private System.Windows.Forms.Button btnMotorcycle;
        private System.Windows.Forms.Button btnShips;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel ChildFormpanel;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label AutoRentLogo;
    }
}

