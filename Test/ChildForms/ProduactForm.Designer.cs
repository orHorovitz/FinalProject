
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelTitleSaction = new System.Windows.Forms.Panel();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ChildFormpanel.SuspendLayout();
            this.panelTitleSaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildFormpanel
            // 
            this.ChildFormpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChildFormpanel.Controls.Add(this.btnDelete);
            this.ChildFormpanel.Controls.Add(this.btnEdit);
            this.ChildFormpanel.Controls.Add(this.flp);
            this.ChildFormpanel.Controls.Add(this.btnAdd);
            this.ChildFormpanel.Controls.Add(this.panelTitleSaction);
            this.ChildFormpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormpanel.Location = new System.Drawing.Point(0, 0);
            this.ChildFormpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChildFormpanel.Name = "ChildFormpanel";
            this.ChildFormpanel.Size = new System.Drawing.Size(1462, 925);
            this.ChildFormpanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Coral;
            this.btnDelete.Location = new System.Drawing.Point(770, 851);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(632, 851);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 57);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(38, 158);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1336, 675);
            this.flp.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(480, 851);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 58);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelTitleSaction
            // 
            this.panelTitleSaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panelTitleSaction.Controls.Add(this.comboBoxList);
            this.panelTitleSaction.Controls.Add(this.lblHeader);
            this.panelTitleSaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleSaction.Location = new System.Drawing.Point(0, 0);
            this.panelTitleSaction.Name = "panelTitleSaction";
            this.panelTitleSaction.Size = new System.Drawing.Size(1462, 125);
            this.panelTitleSaction.TabIndex = 0;
            // 
            // comboBoxList
            // 
            this.comboBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.comboBoxList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxList.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxList.Location = new System.Drawing.Point(1164, 63);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(242, 28);
            this.comboBoxList.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 45F);
            this.lblHeader.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeader.Location = new System.Drawing.Point(474, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(313, 108);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "label1";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProduactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 925);
            this.Controls.Add(this.ChildFormpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduactForm";
            this.Text = "ProduactForm";
            this.ChildFormpanel.ResumeLayout(false);
            this.panelTitleSaction.ResumeLayout(false);
            this.panelTitleSaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormpanel;
        private System.Windows.Forms.Panel panelTitleSaction;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}