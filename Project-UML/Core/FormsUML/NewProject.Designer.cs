
namespace Project_UML.Core.Forms
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
            this.trackBarOfWidth = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAggregation = new System.Windows.Forms.Button();
            this.ButtonComposition = new System.Windows.Forms.Button();
            this.ButtonAssociation = new System.Windows.Forms.Button();
            this.ButtonInheritance = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SaveData = new System.Windows.Forms.Button();
            this.ButtonImplementation = new System.Windows.Forms.Button();
            this.ButtonRectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStartAxis.SuspendLayout();
            this.groupBoxEndAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOfWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 562);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
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
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
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
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // groupBoxStartAxis
            // 
            this.groupBoxStartAxis.Controls.Add(this.radioButton1);
            this.groupBoxStartAxis.Controls.Add(this.radioButton2);
            this.groupBoxStartAxis.Location = new System.Drawing.Point(11, 497);
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
            this.groupBoxEndAxis.Location = new System.Drawing.Point(90, 497);
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
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
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
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBarOfWidth.Location = new System.Drawing.Point(6, 16);
            this.trackBarOfWidth.Maximum = 5;
            this.trackBarOfWidth.Minimum = 1;
            this.trackBarOfWidth.Name = "trackBar1";
            this.trackBarOfWidth.Size = new System.Drawing.Size(104, 45);
            this.trackBarOfWidth.TabIndex = 8;
            this.trackBarOfWidth.Value = 1;
            this.trackBarOfWidth.Scroll += new System.EventHandler(this.TrackBarOfWidth_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarOfWidth);
            this.groupBox2.Location = new System.Drawing.Point(8, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Width";
            // 
            // ButtonAggregation
            // 
            this.ButtonAggregation.Location = new System.Drawing.Point(8, 12);
            this.ButtonAggregation.Name = "ButtonAggregation";
            this.ButtonAggregation.Size = new System.Drawing.Size(150, 25);
            this.ButtonAggregation.TabIndex = 10;
            this.ButtonAggregation.Text = "Aggregation";
            this.ButtonAggregation.UseVisualStyleBackColor = true;
            this.ButtonAggregation.Click += new System.EventHandler(this.ButtonAggregation_Click);
            // 
            // ButtonComposition
            // 
            this.ButtonComposition.Location = new System.Drawing.Point(8, 43);
            this.ButtonComposition.Name = "ButtonComposition";
            this.ButtonComposition.Size = new System.Drawing.Size(150, 25);
            this.ButtonComposition.TabIndex = 11;
            this.ButtonComposition.Text = "Composition";
            this.ButtonComposition.UseVisualStyleBackColor = true;
            this.ButtonComposition.Click += new System.EventHandler(this.ButtonComposition_Click);
            // 
            // ButtonAssociation
            // 
            this.ButtonAssociation.Location = new System.Drawing.Point(8, 74);
            this.ButtonAssociation.Name = "ButtonAssociation";
            this.ButtonAssociation.Size = new System.Drawing.Size(150, 25);
            this.ButtonAssociation.TabIndex = 12;
            this.ButtonAssociation.Text = "Association";
            this.ButtonAssociation.UseVisualStyleBackColor = true;
            this.ButtonAssociation.Click += new System.EventHandler(this.ButtonAssociation_Click);
            // 
            // ButtonInheritance
            // 
            this.ButtonInheritance.Location = new System.Drawing.Point(8, 105);
            this.ButtonInheritance.Name = "ButtonInheritance";
            this.ButtonInheritance.Size = new System.Drawing.Size(150, 25);
            this.ButtonInheritance.TabIndex = 13;
            this.ButtonInheritance.Text = "Inheritance";
            this.ButtonInheritance.UseVisualStyleBackColor = true;
            this.ButtonInheritance.Click += new System.EventHandler(this.ButtonInheritance_Click);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(8, 136);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(150, 25);
            this.ButtonSelect.TabIndex = 14;
            this.ButtonSelect.Text = "Select";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(8, 167);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(150, 25);
            this.ButtonClear.TabIndex = 15;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonColor
            // 
            this.ButtonColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonColor.Location = new System.Drawing.Point(138, 198);
            this.ButtonColor.Name = "ButtonColor";
            this.ButtonColor.Size = new System.Drawing.Size(25, 25);
            this.ButtonColor.TabIndex = 16;
            this.ButtonColor.UseVisualStyleBackColor = false;
            this.ButtonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(1046, 0);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(113, 19);
            this.SaveData.TabIndex = 17;
            this.SaveData.Text = "Save Data";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // ButtonImplementation
            // 
            this.ButtonImplementation.Location = new System.Drawing.Point(8, 281);
            this.ButtonImplementation.Name = "ButtonImplementation";
            this.ButtonImplementation.Size = new System.Drawing.Size(150, 25);
            this.ButtonImplementation.TabIndex = 18;
            this.ButtonImplementation.Text = "Implementation";
            this.ButtonImplementation.UseVisualStyleBackColor = true;
            this.ButtonImplementation.Click += new System.EventHandler(this.ButtonImplementation_Click);
            // 
            // ButtonRectangle
            // 
            this.ButtonRectangle.Location = new System.Drawing.Point(8, 446);
            this.ButtonRectangle.Name = "ButtonRectangle";
            this.ButtonRectangle.Size = new System.Drawing.Size(150, 25);
            this.ButtonRectangle.TabIndex = 18;
            this.ButtonRectangle.Text = "Rectangle";
            this.ButtonRectangle.UseVisualStyleBackColor = true;
            this.ButtonRectangle.Click += new System.EventHandler(this.ButtonRectangle_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 586);
            this.Controls.Add(this.ButtonImplementation);
            this.Controls.Add(this.ButtonRectangle);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ButtonColor);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.ButtonInheritance);
            this.Controls.Add(this.ButtonAssociation);
            this.Controls.Add(this.ButtonComposition);
            this.Controls.Add(this.ButtonAggregation);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOfWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBoxStartAxis;
        private System.Windows.Forms.GroupBox groupBoxEndAxis;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TrackBar trackBarOfWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAggregation;
        private System.Windows.Forms.Button ButtonComposition;
        private System.Windows.Forms.Button ButtonAssociation;
        private System.Windows.Forms.Button ButtonInheritance;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button ButtonImplementation;
        private System.Windows.Forms.Button ButtonRectangle;
    }
}

