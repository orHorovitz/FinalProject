namespace Test.ChildForms
{
    partial class GasCarForm
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
            this.panelTitleGasCar = new System.Windows.Forms.Panel();
            this.lblGasCar = new System.Windows.Forms.Label();
            this.panelGasCar = new System.Windows.Forms.Panel();
            this.GasCarPicture = new System.Windows.Forms.PictureBox();
            this.panelTitleGasCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GasCarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleGasCar
            // 
            this.panelTitleGasCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleGasCar.Controls.Add(this.GasCarPicture);
            this.panelTitleGasCar.Controls.Add(this.lblGasCar);
            this.panelTitleGasCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleGasCar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleGasCar.Name = "panelTitleGasCar";
            this.panelTitleGasCar.Size = new System.Drawing.Size(1169, 100);
            this.panelTitleGasCar.TabIndex = 1;
            // 
            // lblGasCar
            // 
            this.lblGasCar.AutoSize = true;
            this.lblGasCar.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasCar.ForeColor = System.Drawing.Color.LightGray;
            this.lblGasCar.Location = new System.Drawing.Point(12, 9);
            this.lblGasCar.Name = "lblGasCar";
            this.lblGasCar.Size = new System.Drawing.Size(228, 75);
            this.lblGasCar.TabIndex = 0;
            this.lblGasCar.Text = "Gas Car";
            // 
            // panelGasCar
            // 
            this.panelGasCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelGasCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGasCar.Location = new System.Drawing.Point(0, 100);
            this.panelGasCar.Name = "panelGasCar";
            this.panelGasCar.Size = new System.Drawing.Size(1169, 781);
            this.panelGasCar.TabIndex = 2;
            // 
            // GasCarPicture
            // 
            this.GasCarPicture.BackgroundImage = global::Test.Properties.Resources.car_fuel_12847;
            this.GasCarPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GasCarPicture.ErrorImage = global::Test.Properties.Resources.electric_car_12837;
            this.GasCarPicture.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.GasCarPicture.Location = new System.Drawing.Point(246, 3);
            this.GasCarPicture.Name = "GasCarPicture";
            this.GasCarPicture.Size = new System.Drawing.Size(68, 94);
            this.GasCarPicture.TabIndex = 1;
            this.GasCarPicture.TabStop = false;
            // 
            // GasCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 881);
            this.Controls.Add(this.panelGasCar);
            this.Controls.Add(this.panelTitleGasCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GasCarForm";
            this.Text = "GasCarForm";
            this.panelTitleGasCar.ResumeLayout(false);
            this.panelTitleGasCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GasCarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleGasCar;
        private System.Windows.Forms.PictureBox GasCarPicture;
        private System.Windows.Forms.Label lblGasCar;
        private System.Windows.Forms.Panel panelGasCar;
    }
}