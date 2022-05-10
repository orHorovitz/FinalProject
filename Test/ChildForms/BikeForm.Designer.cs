namespace Test.ChildForms
{
    partial class BikeForm
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
            this.panelBike = new System.Windows.Forms.Panel();
            this.panelTitleBike = new System.Windows.Forms.Panel();
            this.lblBikeTitle = new System.Windows.Forms.Label();
            this.BikePicture = new System.Windows.Forms.PictureBox();
            this.panelBike.SuspendLayout();
            this.panelTitleBike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBike
            // 
            this.panelBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelBike.Controls.Add(this.panelTitleBike);
            this.panelBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBike.Location = new System.Drawing.Point(0, 0);
            this.panelBike.Name = "panelBike";
            this.panelBike.Size = new System.Drawing.Size(1153, 842);
            this.panelBike.TabIndex = 4;
            // 
            // panelTitleBike
            // 
            this.panelTitleBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleBike.Controls.Add(this.BikePicture);
            this.panelTitleBike.Controls.Add(this.lblBikeTitle);
            this.panelTitleBike.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBike.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBike.Name = "panelTitleBike";
            this.panelTitleBike.Size = new System.Drawing.Size(1153, 100);
            this.panelTitleBike.TabIndex = 3;
            // 
            // lblBikeTitle
            // 
            this.lblBikeTitle.AutoSize = true;
            this.lblBikeTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblBikeTitle.Location = new System.Drawing.Point(12, 9);
            this.lblBikeTitle.Name = "lblBikeTitle";
            this.lblBikeTitle.Size = new System.Drawing.Size(149, 75);
            this.lblBikeTitle.TabIndex = 0;
            this.lblBikeTitle.Text = "Bike";
            // 
            // BikePicture
            // 
            this.BikePicture.BackgroundImage = global::Test.Properties.Resources.motorcycle32;
            this.BikePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BikePicture.ErrorImage = global::Test.Properties.Resources.electric_car_12837;
            this.BikePicture.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.BikePicture.Location = new System.Drawing.Point(177, 6);
            this.BikePicture.Name = "BikePicture";
            this.BikePicture.Size = new System.Drawing.Size(68, 94);
            this.BikePicture.TabIndex = 1;
            this.BikePicture.TabStop = false;
            // 
            // BikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 842);
            this.Controls.Add(this.panelBike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BikeForm";
            this.Text = "BikeForm";
            this.panelBike.ResumeLayout(false);
            this.panelTitleBike.ResumeLayout(false);
            this.panelTitleBike.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBike;
        private System.Windows.Forms.Panel panelTitleBike;
        private System.Windows.Forms.PictureBox BikePicture;
        private System.Windows.Forms.Label lblBikeTitle;
    }
}