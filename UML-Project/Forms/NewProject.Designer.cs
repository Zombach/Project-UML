
namespace UML_Project
{
    partial class NewProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxStartAxis = new System.Windows.Forms.GroupBox();
            this.groupBoxEndAxis = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAggregation = new System.Windows.Forms.RadioButton();
            this.radioButtonComposition = new System.Windows.Forms.RadioButton();
            this.radioButtonInheritance = new System.Windows.Forms.RadioButton();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonClear = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStartAxis.SuspendLayout();
            this.groupBoxEndAxis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 562);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "X";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Y";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxStartAxis
            // 
            this.groupBoxStartAxis.Controls.Add(this.radioButton1);
            this.groupBoxStartAxis.Controls.Add(this.radioButton2);
            this.groupBoxStartAxis.Location = new System.Drawing.Point(11, 12);
            this.groupBoxStartAxis.Name = "groupBoxStartAxis";
            this.groupBoxStartAxis.Size = new System.Drawing.Size(73, 77);
            this.groupBoxStartAxis.TabIndex = 5;
            this.groupBoxStartAxis.TabStop = false;
            this.groupBoxStartAxis.Text = "StartAxis";
            // 
            // groupBoxEndAxis
            // 
            this.groupBoxEndAxis.Controls.Add(this.radioButton5);
            this.groupBoxEndAxis.Controls.Add(this.radioButton6);
            this.groupBoxEndAxis.Location = new System.Drawing.Point(11, 95);
            this.groupBoxEndAxis.Name = "groupBoxEndAxis";
            this.groupBoxEndAxis.Size = new System.Drawing.Size(73, 77);
            this.groupBoxEndAxis.TabIndex = 6;
            this.groupBoxEndAxis.TabStop = false;
            this.groupBoxEndAxis.Text = "EndAxis";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(32, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "X";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(32, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Y";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonClear);
            this.groupBox1.Controls.Add(this.radioButtonSelect);
            this.groupBox1.Controls.Add(this.radioButtonInheritance);
            this.groupBox1.Controls.Add(this.radioButtonAggregation);
            this.groupBox1.Controls.Add(this.radioButtonComposition);
            this.groupBox1.Location = new System.Drawing.Point(11, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Act";
            // 
            // radioButtonAggregation
            // 
            this.radioButtonAggregation.AutoSize = true;
            this.radioButtonAggregation.Checked = true;
            this.radioButtonAggregation.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAggregation.Name = "radioButtonAggregation";
            this.radioButtonAggregation.Size = new System.Drawing.Size(82, 17);
            this.radioButtonAggregation.TabIndex = 1;
            this.radioButtonAggregation.TabStop = true;
            this.radioButtonAggregation.Text = "Aggregation";
            this.radioButtonAggregation.UseVisualStyleBackColor = true;
            this.radioButtonAggregation.CheckedChanged += new System.EventHandler(this.radioButtonAggregation_CheckedChanged);
            // 
            // radioButtonComposition
            // 
            this.radioButtonComposition.AutoSize = true;
            this.radioButtonComposition.Location = new System.Drawing.Point(6, 42);
            this.radioButtonComposition.Name = "radioButtonComposition";
            this.radioButtonComposition.Size = new System.Drawing.Size(82, 17);
            this.radioButtonComposition.TabIndex = 2;
            this.radioButtonComposition.Text = "Composition";
            this.radioButtonComposition.UseVisualStyleBackColor = true;
            this.radioButtonComposition.CheckedChanged += new System.EventHandler(this.radioButtonComposition_CheckedChanged);
            // 
            // radioButtonInheritance
            // 
            this.radioButtonInheritance.AutoSize = true;
            this.radioButtonInheritance.Location = new System.Drawing.Point(6, 65);
            this.radioButtonInheritance.Name = "radioButtonInheritance";
            this.radioButtonInheritance.Size = new System.Drawing.Size(78, 17);
            this.radioButtonInheritance.TabIndex = 3;
            this.radioButtonInheritance.Text = "Inheritance";
            this.radioButtonInheritance.UseVisualStyleBackColor = true;
            this.radioButtonInheritance.CheckedChanged += new System.EventHandler(this.radioButtonInheritance_CheckedChanged);
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(6, 88);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(87, 17);
            this.radioButtonSelect.TabIndex = 8;
            this.radioButtonSelect.Text = "Select/Move";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            this.radioButtonSelect.CheckedChanged += new System.EventHandler(this.radioButtonSelect_CheckedChanged);
            // 
            // radioButtonClear
            // 
            this.radioButtonClear.AutoSize = true;
            this.radioButtonClear.Location = new System.Drawing.Point(6, 111);
            this.radioButtonClear.Name = "radioButtonClear";
            this.radioButtonClear.Size = new System.Drawing.Size(49, 17);
            this.radioButtonClear.TabIndex = 9;
            this.radioButtonClear.Text = "Clear";
            this.radioButtonClear.UseVisualStyleBackColor = true;
            this.radioButtonClear.CheckedChanged += new System.EventHandler(this.radioButtonClear_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 325);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 586);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEndAxis);
            this.Controls.Add(this.groupBoxStartAxis);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewProject";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.NewProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxStartAxis.ResumeLayout(false);
            this.groupBoxStartAxis.PerformLayout();
            this.groupBoxEndAxis.ResumeLayout(false);
            this.groupBoxEndAxis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBoxStartAxis;
        private System.Windows.Forms.GroupBox groupBoxEndAxis;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSelect;
        private System.Windows.Forms.RadioButton radioButtonInheritance;
        private System.Windows.Forms.RadioButton radioButtonAggregation;
        private System.Windows.Forms.RadioButton radioButtonComposition;
        private System.Windows.Forms.RadioButton radioButtonClear;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

