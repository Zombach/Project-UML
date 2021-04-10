
namespace UML_Project
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
            this.LicenseText = new System.Windows.Forms.ListBox();
            this.License_CheckBox = new System.Windows.Forms.CheckBox();
            this.CreateProject_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LicenseText
            // 
            this.LicenseText.FormattingEnabled = true;
            this.LicenseText.Items.AddRange(new object[] {
            "\t\t       Ололо Лицензия",
            "Собственно тут будет какой-то текст. и тому подобная инфа"});
            this.LicenseText.Location = new System.Drawing.Point(49, 12);
            this.LicenseText.Name = "LicenseText";
            this.LicenseText.Size = new System.Drawing.Size(327, 147);
            this.LicenseText.TabIndex = 0;
            // 
            // License_CheckBox
            // 
            this.License_CheckBox.AutoSize = true;
            this.License_CheckBox.Location = new System.Drawing.Point(135, 165);
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
            this.CreateProject_Button.Location = new System.Drawing.Point(107, 201);
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
            this.Name = "License";
            this.Text = "License Agreement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LicenseText;
        private System.Windows.Forms.CheckBox License_CheckBox;
        private System.Windows.Forms.Button CreateProject_Button;
    }
}

