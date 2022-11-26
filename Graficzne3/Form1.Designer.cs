namespace Graficzne3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bezierCanvas = new System.Windows.Forms.PictureBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.curveSsplitContainer = new System.Windows.Forms.SplitContainer();
            this.saveAllPicturesButton = new System.Windows.Forms.Button();
            this.blackAndWhiteButton = new System.Windows.Forms.Button();
            this.showAllPicturesButton = new System.Windows.Forms.Button();
            this.changePictureButton = new System.Windows.Forms.Button();
            this.SaveCurveButton = new System.Windows.Forms.Button();
            this.loadCurveButton = new System.Windows.Forms.Button();
            this.gcrButton = new System.Windows.Forms.Button();
            this.ucrButton = new System.Windows.Forms.Button();
            this.backtrack100Button = new System.Windows.Forms.Button();
            this.backtrack0Button = new System.Windows.Forms.Button();
            this.showAllCheckBox = new System.Windows.Forms.CheckBox();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.magentaRadioButton = new System.Windows.Forms.RadioButton();
            this.cyanRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bezierCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curveSsplitContainer)).BeginInit();
            this.curveSsplitContainer.Panel1.SuspendLayout();
            this.curveSsplitContainer.Panel2.SuspendLayout();
            this.curveSsplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bezierCanvas
            // 
            this.bezierCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezierCanvas.Location = new System.Drawing.Point(0, 0);
            this.bezierCanvas.Name = "bezierCanvas";
            this.bezierCanvas.Size = new System.Drawing.Size(681, 463);
            this.bezierCanvas.TabIndex = 0;
            this.bezierCanvas.TabStop = false;
            this.bezierCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bezierCanvas_MouseClick);
            this.bezierCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bezierCanvas_MouseDown);
            this.bezierCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bezierCanvas_MouseMove);
            this.bezierCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bezierCanvas_MouseUp);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.curveSsplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1341, 628);
            this.mainSplitContainer.SplitterDistance = 681;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // curveSsplitContainer
            // 
            this.curveSsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curveSsplitContainer.Location = new System.Drawing.Point(0, 0);
            this.curveSsplitContainer.Name = "curveSsplitContainer";
            this.curveSsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // curveSsplitContainer.Panel1
            // 
            this.curveSsplitContainer.Panel1.Controls.Add(this.bezierCanvas);
            // 
            // curveSsplitContainer.Panel2
            // 
            this.curveSsplitContainer.Panel2.Controls.Add(this.saveAllPicturesButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.blackAndWhiteButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.showAllPicturesButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.changePictureButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.SaveCurveButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.loadCurveButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.gcrButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.ucrButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.backtrack100Button);
            this.curveSsplitContainer.Panel2.Controls.Add(this.backtrack0Button);
            this.curveSsplitContainer.Panel2.Controls.Add(this.showAllCheckBox);
            this.curveSsplitContainer.Panel2.Controls.Add(this.blackRadioButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.yellowRadioButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.magentaRadioButton);
            this.curveSsplitContainer.Panel2.Controls.Add(this.cyanRadioButton);
            this.curveSsplitContainer.Size = new System.Drawing.Size(681, 628);
            this.curveSsplitContainer.SplitterDistance = 463;
            this.curveSsplitContainer.TabIndex = 1;
            // 
            // saveAllPicturesButton
            // 
            this.saveAllPicturesButton.Location = new System.Drawing.Point(454, 78);
            this.saveAllPicturesButton.Name = "saveAllPicturesButton";
            this.saveAllPicturesButton.Size = new System.Drawing.Size(94, 64);
            this.saveAllPicturesButton.TabIndex = 14;
            this.saveAllPicturesButton.Text = "Save All Pictures";
            this.saveAllPicturesButton.UseVisualStyleBackColor = true;
            // 
            // blackAndWhiteButton
            // 
            this.blackAndWhiteButton.Location = new System.Drawing.Point(454, 8);
            this.blackAndWhiteButton.Name = "blackAndWhiteButton";
            this.blackAndWhiteButton.Size = new System.Drawing.Size(94, 63);
            this.blackAndWhiteButton.TabIndex = 13;
            this.blackAndWhiteButton.Text = "Black and White";
            this.blackAndWhiteButton.UseVisualStyleBackColor = true;
            // 
            // showAllPicturesButton
            // 
            this.showAllPicturesButton.Location = new System.Drawing.Point(297, 8);
            this.showAllPicturesButton.Name = "showAllPicturesButton";
            this.showAllPicturesButton.Size = new System.Drawing.Size(151, 29);
            this.showAllPicturesButton.TabIndex = 12;
            this.showAllPicturesButton.Text = "Show All Pictures";
            this.showAllPicturesButton.UseVisualStyleBackColor = true;
            this.showAllPicturesButton.Click += new System.EventHandler(this.showAllPicturesButton_Click);
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(297, 43);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(151, 29);
            this.changePictureButton.TabIndex = 11;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // SaveCurveButton
            // 
            this.SaveCurveButton.Location = new System.Drawing.Point(297, 78);
            this.SaveCurveButton.Name = "SaveCurveButton";
            this.SaveCurveButton.Size = new System.Drawing.Size(151, 29);
            this.SaveCurveButton.TabIndex = 10;
            this.SaveCurveButton.Text = "Save Curve";
            this.SaveCurveButton.UseVisualStyleBackColor = true;
            this.SaveCurveButton.Click += new System.EventHandler(this.SaveCurveButton_Click);
            // 
            // loadCurveButton
            // 
            this.loadCurveButton.Location = new System.Drawing.Point(297, 113);
            this.loadCurveButton.Name = "loadCurveButton";
            this.loadCurveButton.Size = new System.Drawing.Size(151, 29);
            this.loadCurveButton.TabIndex = 9;
            this.loadCurveButton.Text = "Load Curve";
            this.loadCurveButton.UseVisualStyleBackColor = true;
            this.loadCurveButton.Click += new System.EventHandler(this.loadCurveButton_Click);
            // 
            // gcrButton
            // 
            this.gcrButton.Location = new System.Drawing.Point(143, 113);
            this.gcrButton.Name = "gcrButton";
            this.gcrButton.Size = new System.Drawing.Size(124, 29);
            this.gcrButton.TabIndex = 8;
            this.gcrButton.Text = "GCR";
            this.gcrButton.UseVisualStyleBackColor = true;
            this.gcrButton.Click += new System.EventHandler(this.gcrButton_Click);
            // 
            // ucrButton
            // 
            this.ucrButton.Location = new System.Drawing.Point(143, 78);
            this.ucrButton.Name = "ucrButton";
            this.ucrButton.Size = new System.Drawing.Size(124, 29);
            this.ucrButton.TabIndex = 7;
            this.ucrButton.Text = "UCR";
            this.ucrButton.UseVisualStyleBackColor = true;
            this.ucrButton.Click += new System.EventHandler(this.ucrButton_Click);
            // 
            // backtrack100Button
            // 
            this.backtrack100Button.Location = new System.Drawing.Point(143, 43);
            this.backtrack100Button.Name = "backtrack100Button";
            this.backtrack100Button.Size = new System.Drawing.Size(124, 29);
            this.backtrack100Button.TabIndex = 6;
            this.backtrack100Button.Text = "100% Backtrack";
            this.backtrack100Button.UseVisualStyleBackColor = true;
            this.backtrack100Button.Click += new System.EventHandler(this.backtrack100Button_Click);
            // 
            // backtrack0Button
            // 
            this.backtrack0Button.Location = new System.Drawing.Point(143, 8);
            this.backtrack0Button.Name = "backtrack0Button";
            this.backtrack0Button.Size = new System.Drawing.Size(124, 29);
            this.backtrack0Button.TabIndex = 5;
            this.backtrack0Button.Text = "0% Backtrack";
            this.backtrack0Button.UseVisualStyleBackColor = true;
            this.backtrack0Button.Click += new System.EventHandler(this.backtrack0Button_Click);
            // 
            // showAllCheckBox
            // 
            this.showAllCheckBox.AutoSize = true;
            this.showAllCheckBox.Location = new System.Drawing.Point(8, 127);
            this.showAllCheckBox.Name = "showAllCheckBox";
            this.showAllCheckBox.Size = new System.Drawing.Size(132, 24);
            this.showAllCheckBox.TabIndex = 4;
            this.showAllCheckBox.Text = "Show all curves";
            this.showAllCheckBox.UseVisualStyleBackColor = true;
            this.showAllCheckBox.CheckedChanged += new System.EventHandler(this.showAllCheckBox_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(8, 98);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(65, 24);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Location = new System.Drawing.Point(8, 68);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(73, 24);
            this.yellowRadioButton.TabIndex = 2;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // magentaRadioButton
            // 
            this.magentaRadioButton.AutoSize = true;
            this.magentaRadioButton.Location = new System.Drawing.Point(8, 38);
            this.magentaRadioButton.Name = "magentaRadioButton";
            this.magentaRadioButton.Size = new System.Drawing.Size(89, 24);
            this.magentaRadioButton.TabIndex = 1;
            this.magentaRadioButton.Text = "Magenta";
            this.magentaRadioButton.UseVisualStyleBackColor = true;
            this.magentaRadioButton.CheckedChanged += new System.EventHandler(this.magentaRadioButton_CheckedChanged);
            // 
            // cyanRadioButton
            // 
            this.cyanRadioButton.AutoSize = true;
            this.cyanRadioButton.Checked = true;
            this.cyanRadioButton.Location = new System.Drawing.Point(9, 8);
            this.cyanRadioButton.Name = "cyanRadioButton";
            this.cyanRadioButton.Size = new System.Drawing.Size(62, 24);
            this.cyanRadioButton.TabIndex = 0;
            this.cyanRadioButton.TabStop = true;
            this.cyanRadioButton.Text = "Cyan";
            this.cyanRadioButton.UseVisualStyleBackColor = true;
            this.cyanRadioButton.CheckedChanged += new System.EventHandler(this.cyanRadioButton_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.colorPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(656, 628);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 0;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(656, 308);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPictureBox.Location = new System.Drawing.Point(0, 0);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(656, 316);
            this.colorPictureBox.TabIndex = 0;
            this.colorPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 628);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bezierCanvas)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.curveSsplitContainer.Panel1.ResumeLayout(false);
            this.curveSsplitContainer.Panel2.ResumeLayout(false);
            this.curveSsplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curveSsplitContainer)).EndInit();
            this.curveSsplitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox bezierCanvas;
        private SplitContainer mainSplitContainer;
        private SplitContainer curveSsplitContainer;
        private Button saveAllPicturesButton;
        private Button blackAndWhiteButton;
        private Button showAllPicturesButton;
        private Button changePictureButton;
        private Button SaveCurveButton;
        private Button loadCurveButton;
        private Button gcrButton;
        private Button ucrButton;
        private Button backtrack100Button;
        private Button backtrack0Button;
        private CheckBox showAllCheckBox;
        private RadioButton blackRadioButton;
        private RadioButton yellowRadioButton;
        private RadioButton magentaRadioButton;
        private RadioButton cyanRadioButton;
        private SplitContainer splitContainer1;
        private PictureBox mainPictureBox;
        private PictureBox colorPictureBox;
    }
}