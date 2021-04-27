
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Save = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.LoadLast = new System.Windows.Forms.Button();
            this.LoadAs = new System.Windows.Forms.Button();
            this.EncryptAs = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.CheckBox();
            this.buttonSaveAsImage = new System.Windows.Forms.Button();
            this.SaveImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(25, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(70, 70);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(101, 12);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(70, 70);
            this.SaveAs.TabIndex = 1;
            this.SaveAs.Text = "Save as";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // LoadLast
            // 
            this.LoadLast.Location = new System.Drawing.Point(25, 88);
            this.LoadLast.Name = "LoadLast";
            this.LoadLast.Size = new System.Drawing.Size(70, 70);
            this.LoadLast.TabIndex = 2;
            this.LoadLast.Text = "Load last";
            this.LoadLast.UseVisualStyleBackColor = true;
            this.LoadLast.Click += new System.EventHandler(this.LoadLast_Click);
            // 
            // LoadAs
            // 
            this.LoadAs.Location = new System.Drawing.Point(101, 88);
            this.LoadAs.Name = "LoadAs";
            this.LoadAs.Size = new System.Drawing.Size(70, 70);
            this.LoadAs.TabIndex = 4;
            this.LoadAs.Text = "Load as";
            this.LoadAs.UseVisualStyleBackColor = true;
            this.LoadAs.Click += new System.EventHandler(this.LoadAs_Click);
            // 
            // EncryptAs
            // 
            this.EncryptAs.Location = new System.Drawing.Point(177, 12);
            this.EncryptAs.Name = "EncryptAs";
            this.EncryptAs.Size = new System.Drawing.Size(70, 70);
            this.EncryptAs.TabIndex = 5;
            this.EncryptAs.Text = "Encrypt as";
            this.EncryptAs.UseVisualStyleBackColor = true;
            this.EncryptAs.Click += new System.EventHandler(this.EncryptAs_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(227, 175);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 30);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(127, 175);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 30);
            this.MainMenu.TabIndex = 7;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Location = new System.Drawing.Point(42, 183);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(62, 17);
            this.Encrypt.TabIndex = 8;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.CheckedChanged += new System.EventHandler(this.Encrypt_Click);
            // 
            // buttonSaveAsImage
            // 
            this.buttonSaveAsImage.Location = new System.Drawing.Point(254, 88);
            this.buttonSaveAsImage.Name = "buttonSaveAsImage";
            this.buttonSaveAsImage.Size = new System.Drawing.Size(70, 70);
            this.buttonSaveAsImage.TabIndex = 9;
            this.buttonSaveAsImage.Text = "Save As Image";
            this.buttonSaveAsImage.UseVisualStyleBackColor = true;
            this.buttonSaveAsImage.Click += new System.EventHandler(this.SaveAsImage_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(178, 88);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(70, 70);
            this.SaveImage.TabIndex = 10;
            this.SaveImage.Text = "Save Image";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Decrypt as";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(346, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.buttonSaveAsImage);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EncryptAs);
            this.Controls.Add(this.LoadAs);
            this.Controls.Add(this.LoadLast);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(362, 262);
            this.MinimumSize = new System.Drawing.Size(362, 262);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Control);
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
        private System.Windows.Forms.Button buttonSaveAsImage;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Button button1;
    }
}