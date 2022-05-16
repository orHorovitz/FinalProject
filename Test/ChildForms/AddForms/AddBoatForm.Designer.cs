
namespace Test.ChildForms.AddForms
{
    partial class AddBoatForm
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
            this.cmdType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdType
            // 
            this.cmdType.FormattingEnabled = true;
            this.cmdType.Location = new System.Drawing.Point(0, 1);
            this.cmdType.Name = "cmdType";
            this.cmdType.Size = new System.Drawing.Size(121, 28);
            this.cmdType.TabIndex = 0;
            this.cmdType.SelectedIndexChanged += new System.EventHandler(this.cmdType_SelectedIndexChanged);
            // 
            // AdBoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 584);
            this.Controls.Add(this.cmdType);
            this.Name = "AdBoatForm";
            this.Text = "AdBoatForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdType;
    }
}