﻿
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
            this.NewProject = new System.Windows.Forms.Button();
            this.LoadProject = new System.Windows.Forms.Button();
            this.AboutUs = new System.Windows.Forms.Button();
            this.ExitProgramm = new System.Windows.Forms.Button();
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
            // LoadProject
            // 
            this.LoadProject.Location = new System.Drawing.Point(63, 89);
            this.LoadProject.Name = "LoadProject";
            this.LoadProject.Size = new System.Drawing.Size(135, 48);
            this.LoadProject.TabIndex = 4;
            this.LoadProject.Text = "Load project";
            this.LoadProject.UseVisualStyleBackColor = true;
            this.LoadProject.Click += new System.EventHandler(this.LoadProject_Click);
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 337);
            this.Controls.Add(this.AboutUs);
            this.Controls.Add(this.ExitProgramm);
            this.Controls.Add(this.LoadProject);
            this.Controls.Add(this.NewProject);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainMenu";
            this.Text = "UML Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button LoadProject;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button ExitProgramm;
    }
}

