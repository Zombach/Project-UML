
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProject));
            this.Canvas = new System.Windows.Forms.PictureBox();
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
            this.ButtonRectangleObject = new System.Windows.Forms.Button();
            this.ButtonRectangleEnum = new System.Windows.Forms.Button();
            this.ButtonRectangleInterface = new System.Windows.Forms.Button();
            this.ButtonRectangleClass = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.groupBoxStartAxis.SuspendLayout();
            this.groupBoxEndAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOfWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.BackColor = System.Drawing.Color.Gainsboro;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // groupBoxStartAxis
            // 
            this.groupBoxStartAxis.Controls.Add(this.radioButton1);
            this.groupBoxStartAxis.Controls.Add(this.radioButton2);
            resources.ApplyResources(this.groupBoxStartAxis, "groupBoxStartAxis");
            this.groupBoxStartAxis.Name = "groupBoxStartAxis";
            this.groupBoxStartAxis.TabStop = false;
            // 
            // groupBoxEndAxis
            // 
            this.groupBoxEndAxis.Controls.Add(this.radioButton5);
            this.groupBoxEndAxis.Controls.Add(this.radioButton6);
            resources.ApplyResources(this.groupBoxEndAxis, "groupBoxEndAxis");
            this.groupBoxEndAxis.Name = "groupBoxEndAxis";
            this.groupBoxEndAxis.TabStop = false;
            // 
            // radioButton5
            // 
            resources.ApplyResources(this.radioButton5, "radioButton5");
            this.radioButton5.Checked = true;
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            resources.ApplyResources(this.radioButton6, "radioButton6");
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // trackBarOfWidth
            // 
            resources.ApplyResources(this.trackBarOfWidth, "trackBarOfWidth");
            this.trackBarOfWidth.Maximum = 5;
            this.trackBarOfWidth.Minimum = 1;
            this.trackBarOfWidth.Name = "trackBarOfWidth";
            this.trackBarOfWidth.Value = 1;
            this.trackBarOfWidth.Scroll += new System.EventHandler(this.TrackBarOfWidth_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarOfWidth);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ButtonAggregation
            // 
            resources.ApplyResources(this.ButtonAggregation, "ButtonAggregation");
            this.ButtonAggregation.Name = "ButtonAggregation";
            this.ButtonAggregation.UseVisualStyleBackColor = true;
            this.ButtonAggregation.Click += new System.EventHandler(this.ButtonAggregation_Click);
            // 
            // ButtonComposition
            // 
            resources.ApplyResources(this.ButtonComposition, "ButtonComposition");
            this.ButtonComposition.Name = "ButtonComposition";
            this.ButtonComposition.UseVisualStyleBackColor = true;
            this.ButtonComposition.Click += new System.EventHandler(this.ButtonComposition_Click);
            // 
            // ButtonAssociation
            // 
            resources.ApplyResources(this.ButtonAssociation, "ButtonAssociation");
            this.ButtonAssociation.Name = "ButtonAssociation";
            this.ButtonAssociation.UseVisualStyleBackColor = true;
            this.ButtonAssociation.Click += new System.EventHandler(this.ButtonAssociation_Click);
            // 
            // ButtonInheritance
            // 
            resources.ApplyResources(this.ButtonInheritance, "ButtonInheritance");
            this.ButtonInheritance.Name = "ButtonInheritance";
            this.ButtonInheritance.UseVisualStyleBackColor = true;
            this.ButtonInheritance.Click += new System.EventHandler(this.ButtonInheritance_Click);
            // 
            // ButtonSelect
            // 
            resources.ApplyResources(this.ButtonSelect, "ButtonSelect");
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonClear
            // 
            resources.ApplyResources(this.ButtonClear, "ButtonClear");
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonColor
            // 
            this.ButtonColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.ButtonColor, "ButtonColor");
            this.ButtonColor.Name = "ButtonColor";
            this.ButtonColor.UseVisualStyleBackColor = false;
            this.ButtonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // SaveData
            // 
            resources.ApplyResources(this.SaveData, "SaveData");
            this.SaveData.Name = "SaveData";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // ButtonImplementation
            // 
            resources.ApplyResources(this.ButtonImplementation, "ButtonImplementation");
            this.ButtonImplementation.Name = "ButtonImplementation";
            this.ButtonImplementation.UseVisualStyleBackColor = true;
            this.ButtonImplementation.Click += new System.EventHandler(this.ButtonImplementation_Click);
            // 
            // ButtonRectangleObject
            // 
            resources.ApplyResources(this.ButtonRectangleObject, "ButtonRectangleObject");
            this.ButtonRectangleObject.Name = "ButtonRectangleObject";
            this.ButtonRectangleObject.UseVisualStyleBackColor = true;
            this.ButtonRectangleObject.Click += new System.EventHandler(this.ButtonRectangleObject_Click);
            // 
            // ButtonRectangleEnum
            // 
            resources.ApplyResources(this.ButtonRectangleEnum, "ButtonRectangleEnum");
            this.ButtonRectangleEnum.Name = "ButtonRectangleEnum";
            this.ButtonRectangleEnum.UseVisualStyleBackColor = true;
            this.ButtonRectangleEnum.Click += new System.EventHandler(this.ButtonRectangleEnum_Click);
            // 
            // ButtonRectangleInterface
            // 
            resources.ApplyResources(this.ButtonRectangleInterface, "ButtonRectangleInterface");
            this.ButtonRectangleInterface.Name = "ButtonRectangleInterface";
            this.ButtonRectangleInterface.UseVisualStyleBackColor = true;
            this.ButtonRectangleInterface.Click += new System.EventHandler(this.ButtonRectangleInterface_Click);
            // 
            // ButtonRectangleClass
            // 
            resources.ApplyResources(this.ButtonRectangleClass, "ButtonRectangleClass");
            this.ButtonRectangleClass.Name = "ButtonRectangleClass";
            this.ButtonRectangleClass.UseVisualStyleBackColor = true;
            this.ButtonRectangleClass.Click += new System.EventHandler(this.ButtonRectangleClass_Click);
            // 
            // Test
            // 
            resources.ApplyResources(this.Test, "Test");
            this.Test.Name = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // buttonTransform
            // 
            resources.ApplyResources(this.buttonTransform, "buttonTransform");
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonMove
            // 
            resources.ApplyResources(this.buttonMove, "buttonMove");
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click_1);
            // 
            // NewProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.ButtonRectangleClass);
            this.Controls.Add(this.ButtonRectangleInterface);
            this.Controls.Add(this.ButtonRectangleEnum);
            this.Controls.Add(this.ButtonImplementation);
            this.Controls.Add(this.ButtonRectangleObject);
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
            this.Controls.Add(this.Canvas);
            this.Name = "NewProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
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

        private System.Windows.Forms.PictureBox Canvas;
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
        private System.Windows.Forms.Button ButtonRectangleObject;
        private System.Windows.Forms.Button ButtonRectangleEnum;
        private System.Windows.Forms.Button ButtonRectangleInterface;
        private System.Windows.Forms.Button ButtonRectangleClass;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonMove;
    }
}

