
namespace Project_UML.Core.FormsUML
{
    public partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewProject = new System.Windows.Forms.Button();
            this.AboutUs = new System.Windows.Forms.Button();
            this.ExitProgramm = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.LoadAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewProject
            // 
            this.NewProject.Location = new System.Drawing.Point(63, 34);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(135, 48);
            this.NewProject.TabIndex = 0;
            this.NewProject.Text = "New project";
            this.NewProject.UseVisualStyleBackColor = true;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Location = new System.Drawing.Point(63, 199);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(135, 48);
            this.AboutUs.TabIndex = 1;
            this.AboutUs.Text = "About us";
            this.AboutUs.UseVisualStyleBackColor = true;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // ExitProgramm
            // 
            this.ExitProgramm.Location = new System.Drawing.Point(63, 254);
            this.ExitProgramm.Name = "ExitProgramm";
            this.ExitProgramm.Size = new System.Drawing.Size(135, 48);
            this.ExitProgramm.TabIndex = 2;
            this.ExitProgramm.Text = "Exit";
            this.ExitProgramm.UseVisualStyleBackColor = true;
            this.ExitProgramm.Click += new System.EventHandler(this.ExitProgramm_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(64, 88);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(134, 48);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // LoadAs
            // 
            this.LoadAs.Location = new System.Drawing.Point(65, 144);
            this.LoadAs.Name = "LoadAs";
            this.LoadAs.Size = new System.Drawing.Size(134, 48);
            this.LoadAs.TabIndex = 4;
            this.LoadAs.Text = "Load as";
            this.LoadAs.UseVisualStyleBackColor = true;
            this.LoadAs.Click += new System.EventHandler(this.LoadAs_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 337);
            this.Controls.Add(this.LoadAs);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.AboutUs);
            this.Controls.Add(this.ExitProgramm);
            this.Controls.Add(this.NewProject);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(280, 376);
            this.MinimumSize = new System.Drawing.Size(280, 376);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UML Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button ExitProgramm;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button LoadAs;
    }
}

