
namespace Project_UML.Core.FormsUML
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.HelpText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.Enabled = false;
            this.HelpText.FormattingEnabled = true;
            this.HelpText.Location = new System.Drawing.Point(4, 4);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(294, 381);
            this.HelpText.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(302, 389);
            this.ControlBox = false;
            this.Controls.Add(this.HelpText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(1550, 50);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(318, 428);
            this.Name = "Help";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Help";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Control);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox HelpText;
    }
}