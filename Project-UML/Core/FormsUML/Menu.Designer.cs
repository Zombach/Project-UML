
namespace Project_UML.Core.FormsUML
{
    partial class Menu
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
            this.Save = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.LoadLast = new System.Windows.Forms.Button();
            this.LoadAs = new System.Windows.Forms.Button();
            this.EncryptAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(46, 28);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(166, 28);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(75, 23);
            this.SaveAs.TabIndex = 1;
            this.SaveAs.Text = "Save as";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // LoadLast
            // 
            this.LoadLast.Location = new System.Drawing.Point(299, 28);
            this.LoadLast.Name = "LoadLast";
            this.LoadLast.Size = new System.Drawing.Size(75, 23);
            this.LoadLast.TabIndex = 2;
            this.LoadLast.Text = "Load last";
            this.LoadLast.UseVisualStyleBackColor = true;
            this.LoadLast.Click += new System.EventHandler(this.LoadLast_Click);
            // 
            // LoadAs
            // 
            this.LoadAs.Location = new System.Drawing.Point(299, 84);
            this.LoadAs.Name = "LoadAs";
            this.LoadAs.Size = new System.Drawing.Size(75, 23);
            this.LoadAs.TabIndex = 4;
            this.LoadAs.Text = "Load as";
            this.LoadAs.UseVisualStyleBackColor = true;
            this.LoadAs.Click += new System.EventHandler(this.LoadAs_Click);
            // 
            // EncryptAs
            // 
            this.EncryptAs.Location = new System.Drawing.Point(166, 82);
            this.EncryptAs.Name = "EncryptAs";
            this.EncryptAs.Size = new System.Drawing.Size(75, 23);
            this.EncryptAs.TabIndex = 5;
            this.EncryptAs.Text = "Encrypt as";
            this.EncryptAs.UseVisualStyleBackColor = true;
            this.EncryptAs.Click += new System.EventHandler(this.EncryptAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(299, 188);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(166, 188);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 7;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Location = new System.Drawing.Point(59, 88);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(62, 17);
            this.Encrypt.TabIndex = 8;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.CheckedChanged += new System.EventHandler(this.Encrypt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(434, 223);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EncryptAs);
            this.Controls.Add(this.LoadAs);
            this.Controls.Add(this.LoadLast);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Save);
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Control);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button LoadLast;
        private System.Windows.Forms.Button LoadAs;
        private System.Windows.Forms.Button EncryptAs;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.CheckBox Encrypt;
    }
}