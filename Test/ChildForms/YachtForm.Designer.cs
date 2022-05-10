namespace Test.ChildForms
{
    partial class YachtForm
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
            this.panelTitleYachtBoat = new System.Windows.Forms.Panel();
            this.lblYachtBoat = new System.Windows.Forms.Label();
            this.panelYacht = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleYachtBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleYachtBoat
            // 
            this.panelTitleYachtBoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleYachtBoat.Controls.Add(this.pictureBox1);
            this.panelTitleYachtBoat.Controls.Add(this.lblYachtBoat);
            this.panelTitleYachtBoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleYachtBoat.Location = new System.Drawing.Point(0, 0);
            this.panelTitleYachtBoat.Name = "panelTitleYachtBoat";
            this.panelTitleYachtBoat.Size = new System.Drawing.Size(1153, 100);
            this.panelTitleYachtBoat.TabIndex = 2;
            // 
            // lblYachtBoat
            // 
            this.lblYachtBoat.AutoSize = true;
            this.lblYachtBoat.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYachtBoat.ForeColor = System.Drawing.Color.LightGray;
            this.lblYachtBoat.Location = new System.Drawing.Point(12, 9);
            this.lblYachtBoat.Name = "lblYachtBoat";
            this.lblYachtBoat.Size = new System.Drawing.Size(322, 75);
            this.lblYachtBoat.TabIndex = 0;
            this.lblYachtBoat.Text = "Yacht Boat";
            // 
            // panelYacht
            // 
            this.panelYacht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelYacht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelYacht.Location = new System.Drawing.Point(0, 100);
            this.panelYacht.Name = "panelYacht";
            this.panelYacht.Size = new System.Drawing.Size(1153, 742);
            this.panelYacht.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Test.Properties.Resources.ship_1051;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::Test.Properties.Resources.electric_car_12837;
            this.pictureBox1.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.pictureBox1.Location = new System.Drawing.Point(340, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 94);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // YachtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 842);
            this.Controls.Add(this.panelYacht);
            this.Controls.Add(this.panelTitleYachtBoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YachtForm";
            this.Text = "YachtForm";
            this.panelTitleYachtBoat.ResumeLayout(false);
            this.panelTitleYachtBoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleYachtBoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblYachtBoat;
        private System.Windows.Forms.Panel panelYacht;
    }
}