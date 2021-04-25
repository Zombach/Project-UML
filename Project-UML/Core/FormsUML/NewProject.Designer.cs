
namespace Project_UML.Core.FormsUML
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
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.GroupBoxStartAxis = new System.Windows.Forms.GroupBox();
            this.GroupBoxEndAxis = new System.Windows.Forms.GroupBox();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
            this.TrackBarOfWidth = new System.Windows.Forms.TrackBar();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonAggregation = new System.Windows.Forms.Button();
            this.ButtonComposition = new System.Windows.Forms.Button();
            this.ButtonAssociation = new System.Windows.Forms.Button();
            this.ButtonInheritance = new System.Windows.Forms.Button();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonColor = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SaveData = new System.Windows.Forms.Button();
            this.ButtonImplementation = new System.Windows.Forms.Button();
            this.ButtonRectangleObject = new System.Windows.Forms.Button();
            this.ButtonRectangleEnum = new System.Windows.Forms.Button();
            this.ButtonRectangleInterface = new System.Windows.Forms.Button();
            this.ButtonRectangleClass = new System.Windows.Forms.Button();
            this.ButtonTransform = new System.Windows.Forms.Button();
            this.ButtonMove = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarOfStep = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonUpdateRectText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.GroupBoxStartAxis.SuspendLayout();
            this.GroupBoxEndAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOfWidth)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOfStep)).BeginInit();
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
            // RadioButton1
            // 
            resources.ApplyResources(this.RadioButton1, "RadioButton1");
            this.RadioButton1.Checked = true;
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.TabStop = true;
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            resources.ApplyResources(this.RadioButton2, "RadioButton2");
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // GroupBoxStartAxis
            // 
            this.GroupBoxStartAxis.Controls.Add(this.RadioButton1);
            this.GroupBoxStartAxis.Controls.Add(this.RadioButton2);
            resources.ApplyResources(this.GroupBoxStartAxis, "GroupBoxStartAxis");
            this.GroupBoxStartAxis.Name = "GroupBoxStartAxis";
            this.GroupBoxStartAxis.TabStop = false;
            // 
            // GroupBoxEndAxis
            // 
            this.GroupBoxEndAxis.Controls.Add(this.RadioButton5);
            this.GroupBoxEndAxis.Controls.Add(this.RadioButton6);
            resources.ApplyResources(this.GroupBoxEndAxis, "GroupBoxEndAxis");
            this.GroupBoxEndAxis.Name = "GroupBoxEndAxis";
            this.GroupBoxEndAxis.TabStop = false;
            // 
            // RadioButton5
            // 
            resources.ApplyResources(this.RadioButton5, "RadioButton5");
            this.RadioButton5.Checked = true;
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.TabStop = true;
            this.RadioButton5.UseVisualStyleBackColor = true;
            this.RadioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // RadioButton6
            // 
            resources.ApplyResources(this.RadioButton6, "RadioButton6");
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.UseVisualStyleBackColor = true;
            this.RadioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // TrackBarOfWidth
            // 
            resources.ApplyResources(this.TrackBarOfWidth, "TrackBarOfWidth");
            this.TrackBarOfWidth.Maximum = 5;
            this.TrackBarOfWidth.Minimum = 1;
            this.TrackBarOfWidth.Name = "TrackBarOfWidth";
            this.TrackBarOfWidth.Value = 1;
            this.TrackBarOfWidth.Scroll += new System.EventHandler(this.TrackBarOfWidth_Scroll);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TrackBarOfWidth);
            resources.ApplyResources(this.GroupBox2, "GroupBox2");
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.TabStop = false;
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
            // ButtonTransform
            // 
            resources.ApplyResources(this.ButtonTransform, "ButtonTransform");
            this.ButtonTransform.Name = "ButtonTransform";
            this.ButtonTransform.UseVisualStyleBackColor = true;
            this.ButtonTransform.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // ButtonMove
            // 
            resources.ApplyResources(this.ButtonMove, "ButtonMove");
            this.ButtonMove.Name = "ButtonMove";
            this.ButtonMove.UseVisualStyleBackColor = true;
            this.ButtonMove.Click += new System.EventHandler(this.ButtonMove_Click_1);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.trackBarOfStep);
            resources.ApplyResources(this.GroupBox1, "GroupBox1");
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.TabStop = false;
            // 
            // trackBarOfStep
            // 
            resources.ApplyResources(this.trackBarOfStep, "trackBarOfStep");
            this.trackBarOfStep.LargeChange = 0;
            this.trackBarOfStep.Maximum = 5;
            this.trackBarOfStep.Minimum = 1;
            this.trackBarOfStep.Name = "trackBarOfStep";
            this.trackBarOfStep.SmallChange = 0;
            this.trackBarOfStep.Value = 1;
            this.trackBarOfStep.Scroll += new System.EventHandler(this.TrackBarOfStep_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // buttonUpdateRectText
            // 
            resources.ApplyResources(this.buttonUpdateRectText, "buttonUpdateRectText");
            this.buttonUpdateRectText.Name = "buttonUpdateRectText";
            this.buttonUpdateRectText.UseVisualStyleBackColor = true;
            this.buttonUpdateRectText.Click += new System.EventHandler(this.buttonUpdateRectText_Click);
            // 
            // NewProject
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdateRectText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ButtonMove);
            this.Controls.Add(this.ButtonTransform);
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
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBoxEndAxis);
            this.Controls.Add(this.GroupBoxStartAxis);
            this.Controls.Add(this.Canvas);
            this.KeyPreview = true;
            this.Name = "NewProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProject_FormClosing);
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Esc);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Control);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Del);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Plus);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Minus);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Zero);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Up);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Down);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Left);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Right);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_A);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_C);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_R);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_S);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_L);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_V);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Z);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressControl);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpControl);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.GroupBoxStartAxis.ResumeLayout(false);
            this.GroupBoxStartAxis.PerformLayout();
            this.GroupBoxEndAxis.ResumeLayout(false);
            this.GroupBoxEndAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarOfWidth)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOfStep)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.GroupBox GroupBoxStartAxis;
        private System.Windows.Forms.GroupBox GroupBoxEndAxis;
        private System.Windows.Forms.RadioButton RadioButton5;
        private System.Windows.Forms.RadioButton RadioButton6;
        private System.Windows.Forms.TrackBar TrackBarOfWidth;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button ButtonAggregation;
        private System.Windows.Forms.Button ButtonComposition;
        private System.Windows.Forms.Button ButtonAssociation;
        private System.Windows.Forms.Button ButtonInheritance;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonColor;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button ButtonImplementation;
        private System.Windows.Forms.Button ButtonRectangleObject;
        private System.Windows.Forms.Button ButtonRectangleEnum;
        private System.Windows.Forms.Button ButtonRectangleInterface;
        private System.Windows.Forms.Button ButtonRectangleClass;
        private System.Windows.Forms.Button ButtonTransform;
        private System.Windows.Forms.Button ButtonMove;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TrackBar trackBarOfStep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonUpdateRectText;
    }
}

