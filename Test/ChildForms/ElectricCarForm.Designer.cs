namespace Test.ChildForms
{
    partial class ElectricCarForm
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
            this.panelTitleElectricCar = new System.Windows.Forms.Panel();
            this.lblElectricCarTitle = new System.Windows.Forms.Label();
            this.ElectricCarPicture = new System.Windows.Forms.PictureBox();
            this.panelTitleElectricCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricCarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleElectricCar
            // 
            this.panelTitleElectricCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleElectricCar.Controls.Add(this.ElectricCarPicture);
            this.panelTitleElectricCar.Controls.Add(this.lblElectricCarTitle);
            this.panelTitleElectricCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleElectricCar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleElectricCar.Name = "panelTitleElectricCar";
            this.panelTitleElectricCar.Size = new System.Drawing.Size(1169, 100);
            this.panelTitleElectricCar.TabIndex = 0;
            // 
            // lblElectricCarTitle
            // 
            this.lblElectricCarTitle.AutoSize = true;
            this.lblElectricCarTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricCarTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblElectricCarTitle.Location = new System.Drawing.Point(12, 9);
            this.lblElectricCarTitle.Name = "lblElectricCarTitle";
            this.lblElectricCarTitle.Size = new System.Drawing.Size(340, 75);
            this.lblElectricCarTitle.TabIndex = 0;
            this.lblElectricCarTitle.Text = "Electric Car ";
            // 
            // ElectricCarPicture
            // 
            this.ElectricCarPicture.BackgroundImage = global::Test.Properties.Resources.electric_car_12837;
            this.ElectricCarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ElectricCarPicture.ErrorImage = global::Test.Properties.Resources.electric_car_12837;
            this.ElectricCarPicture.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.ElectricCarPicture.Location = new System.Drawing.Point(329, 6);
            this.ElectricCarPicture.Name = "ElectricCarPicture";
            this.ElectricCarPicture.Size = new System.Drawing.Size(68, 94);
            this.ElectricCarPicture.TabIndex = 1;
            this.ElectricCarPicture.TabStop = false;
            this.ElectricCarPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ElectricCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1169, 881);
            this.Controls.Add(this.panelTitleElectricCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElectricCarForm";
            this.Text = "ElectricCarForm";
            this.panelTitleElectricCar.ResumeLayout(false);
            this.panelTitleElectricCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricCarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleElectricCar;
        private System.Windows.Forms.Label lblElectricCarTitle;
        private System.Windows.Forms.PictureBox ElectricCarPicture;
    }
}