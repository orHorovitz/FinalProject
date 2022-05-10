
namespace Test.ChildForms
{
    partial class ProduactForm
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
            this.ChildFormpanel = new System.Windows.Forms.Panel();
            this.panelTitleSaction = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ChildFormpanel.SuspendLayout();
            this.panelTitleSaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildFormpanel
            // 
            this.ChildFormpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChildFormpanel.Controls.Add(this.panelTitleSaction);
            this.ChildFormpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormpanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormpanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChildFormpanel.Name = "ChildFormpanel";
            this.ChildFormpanel.Size = new System.Drawing.Size(1710, 840);
            this.ChildFormpanel.TabIndex = 2;
            this.ChildFormpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildFormpanel_Paint);
            // 
            // panelTitleSaction
            // 
            this.panelTitleSaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panelTitleSaction.Controls.Add(this.pictureBox);
            this.panelTitleSaction.Controls.Add(this.comboBoxList);
            this.panelTitleSaction.Controls.Add(this.lblHeader);
            this.panelTitleSaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleSaction.Location = new System.Drawing.Point(0, 0);
            this.panelTitleSaction.Name = "panelTitleSaction";
            this.panelTitleSaction.Size = new System.Drawing.Size(1710, 100);
            this.panelTitleSaction.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe Print", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeader.Location = new System.Drawing.Point(103, -16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(250, 116);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            // 
            // comboBoxList
            // 
            this.comboBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.comboBoxList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxList.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Location = new System.Drawing.Point(1034, 51);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(216, 24);
            this.comboBoxList.TabIndex = 1;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.comboBoxList_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(433, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // ProduactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.ChildFormpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduactForm";
            this.Text = "ProduactForm";
            this.ChildFormpanel.ResumeLayout(false);
            this.panelTitleSaction.ResumeLayout(false);
            this.panelTitleSaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormpanel;
        private System.Windows.Forms.Panel panelTitleSaction;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}