namespace Test.ChildForms
{
    partial class AtvForm
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
            this.panelAtv = new System.Windows.Forms.Panel();
            this.panelTitleAtv = new System.Windows.Forms.Panel();
            this.lblAtv = new System.Windows.Forms.Label();
            this.ATVpicture = new System.Windows.Forms.PictureBox();
            this.panelAtv.SuspendLayout();
            this.panelTitleAtv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATVpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAtv
            // 
            this.panelAtv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelAtv.Controls.Add(this.panelTitleAtv);
            this.panelAtv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAtv.Location = new System.Drawing.Point(0, 0);
            this.panelAtv.Name = "panelAtv";
            this.panelAtv.Size = new System.Drawing.Size(1137, 803);
            this.panelAtv.TabIndex = 4;
            // 
            // panelTitleAtv
            // 
            this.panelTitleAtv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleAtv.Controls.Add(this.ATVpicture);
            this.panelTitleAtv.Controls.Add(this.lblAtv);
            this.panelTitleAtv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleAtv.Location = new System.Drawing.Point(0, 0);
            this.panelTitleAtv.Name = "panelTitleAtv";
            this.panelTitleAtv.Size = new System.Drawing.Size(1137, 100);
            this.panelTitleAtv.TabIndex = 3;
            // 
            // lblAtv
            // 
            this.lblAtv.AutoSize = true;
            this.lblAtv.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtv.ForeColor = System.Drawing.Color.LightGray;
            this.lblAtv.Location = new System.Drawing.Point(12, 9);
            this.lblAtv.Name = "lblAtv";
            this.lblAtv.Size = new System.Drawing.Size(190, 75);
            this.lblAtv.TabIndex = 0;
            this.lblAtv.Text = "ATV";
            // 
            // ATVpicture
            // 
            this.ATVpicture.BackgroundImage = global::Test.Properties.Resources.car_2900;
            this.ATVpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ATVpicture.ErrorImage = global::Test.Properties.Resources.electric_car_12837;
            this.ATVpicture.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.ATVpicture.Location = new System.Drawing.Point(208, 3);
            this.ATVpicture.Name = "ATVpicture";
            this.ATVpicture.Size = new System.Drawing.Size(68, 94);
            this.ATVpicture.TabIndex = 1;
            this.ATVpicture.TabStop = false;
            // 
            // AtvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 803);
            this.Controls.Add(this.panelAtv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtvForm";
            this.Text = "AtvForm";
            this.panelAtv.ResumeLayout(false);
            this.panelTitleAtv.ResumeLayout(false);
            this.panelTitleAtv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATVpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtv;
        private System.Windows.Forms.Panel panelTitleAtv;
        private System.Windows.Forms.PictureBox ATVpicture;
        private System.Windows.Forms.Label lblAtv;
    }
}