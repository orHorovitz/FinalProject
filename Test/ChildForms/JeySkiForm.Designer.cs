namespace Test.ChildForms
{
    partial class JeySkiForm
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
            this.panelJetSki = new System.Windows.Forms.Panel();
            this.panelTitleJetski = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.JetskiPicture = new System.Windows.Forms.PictureBox();
            this.panelJetSki.SuspendLayout();
            this.panelTitleJetski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JetskiPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJetSki
            // 
            this.panelJetSki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelJetSki.Controls.Add(this.panelTitleJetski);
            this.panelJetSki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJetSki.Location = new System.Drawing.Point(0, 0);
            this.panelJetSki.Name = "panelJetSki";
            this.panelJetSki.Size = new System.Drawing.Size(1153, 842);
            this.panelJetSki.TabIndex = 3;
            // 
            // panelTitleJetski
            // 
            this.panelTitleJetski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTitleJetski.Controls.Add(this.JetskiPicture);
            this.panelTitleJetski.Controls.Add(this.label1);
            this.panelTitleJetski.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleJetski.Location = new System.Drawing.Point(0, 0);
            this.panelTitleJetski.Name = "panelTitleJetski";
            this.panelTitleJetski.Size = new System.Drawing.Size(1153, 100);
            this.panelTitleJetski.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jetski ";
            // 
            // JetskiPicture
            // 
            this.JetskiPicture.BackgroundImage = global::Test.Properties.Resources.jet_ski_1823;
            this.JetskiPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.JetskiPicture.ErrorImage = global::Test.Properties.Resources.jet_ski_1823;
            this.JetskiPicture.InitialImage = global::Test.Properties.Resources.electric_car_12837;
            this.JetskiPicture.Location = new System.Drawing.Point(185, 3);
            this.JetskiPicture.Name = "JetskiPicture";
            this.JetskiPicture.Size = new System.Drawing.Size(132, 94);
            this.JetskiPicture.TabIndex = 1;
            this.JetskiPicture.TabStop = false;
            // 
            // JeySkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 842);
            this.Controls.Add(this.panelJetSki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JeySkiForm";
            this.Text = "JeySkiForm";
            this.panelJetSki.ResumeLayout(false);
            this.panelTitleJetski.ResumeLayout(false);
            this.panelTitleJetski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JetskiPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelJetSki;
        private System.Windows.Forms.Panel panelTitleJetski;
        private System.Windows.Forms.PictureBox JetskiPicture;
        private System.Windows.Forms.Label label1;
    }
}