
namespace Project_UML.Core.FormsUML
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.LicenseText = new System.Windows.Forms.ListBox();
            this.License_CheckBox = new System.Windows.Forms.CheckBox();
            this.CreateProject_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LicenseText
            // 
            this.LicenseText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseText.FormattingEnabled = true;
            this.LicenseText.Location = new System.Drawing.Point(34, 63);
            this.LicenseText.MaximumSize = new System.Drawing.Size(361, 780);
            this.LicenseText.MinimumSize = new System.Drawing.Size(361, 160);
            this.LicenseText.Name = "LicenseText";
            this.LicenseText.Size = new System.Drawing.Size(361, 160);
            this.LicenseText.TabIndex = 0;
            // 
            // License_CheckBox
            // 
            this.License_CheckBox.AutoSize = true;
            this.License_CheckBox.Location = new System.Drawing.Point(34, 22);
            this.License_CheckBox.Name = "License_CheckBox";
            this.License_CheckBox.Size = new System.Drawing.Size(152, 17);
            this.License_CheckBox.TabIndex = 1;
            this.License_CheckBox.Text = "Accept license agreement ";
            this.License_CheckBox.UseVisualStyleBackColor = true;
            this.License_CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_License_CheckedChanged);
            // 
            // CreateProject_Button
            // 
            this.CreateProject_Button.Enabled = false;
            this.CreateProject_Button.Location = new System.Drawing.Point(192, 12);
            this.CreateProject_Button.Name = "CreateProject_Button";
            this.CreateProject_Button.Size = new System.Drawing.Size(203, 34);
            this.CreateProject_Button.TabIndex = 2;
            this.CreateProject_Button.Text = "Create Project";
            this.CreateProject_Button.UseVisualStyleBackColor = true;
            this.CreateProject_Button.Click += new System.EventHandler(this.CreateNewProject_Button_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 257);
            this.Controls.Add(this.CreateProject_Button);
            this.Controls.Add(this.License_CheckBox);
            this.Controls.Add(this.LicenseText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(456, 800);
            this.MinimumSize = new System.Drawing.Size(456, 296);
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Agreement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.License_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Control);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LicenseText;
        private System.Windows.Forms.CheckBox License_CheckBox;
        private System.Windows.Forms.Button CreateProject_Button;
    }
}

