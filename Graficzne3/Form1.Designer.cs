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
            this.savePicturesButton = new System.Windows.Forms.Button();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cyanPictureBox = new System.Windows.Forms.PictureBox();
            this.blackPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowPictureBox = new System.Windows.Forms.PictureBox();
            this.magentaPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bezierCanvas
            // 
            this.bezierCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezierCanvas.Location = new System.Drawing.Point(0, 0);
            this.bezierCanvas.Name = "bezierCanvas";
            this.bezierCanvas.Size = new System.Drawing.Size(575, 463);
            this.bezierCanvas.TabIndex = 0;
            this.bezierCanvas.TabStop = false;
            this.bezierCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bezierCanvas_MouseClick);
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
            this.mainSplitContainer.Size = new System.Drawing.Size(1131, 628);
            this.mainSplitContainer.SplitterDistance = 575;
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
            this.curveSsplitContainer.Panel2.Controls.Add(this.savePicturesButton);
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
            this.curveSsplitContainer.Size = new System.Drawing.Size(575, 628);
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
            // savePicturesButton
            // 
            this.savePicturesButton.Location = new System.Drawing.Point(297, 8);
            this.savePicturesButton.Name = "savePicturesButton";
            this.savePicturesButton.Size = new System.Drawing.Size(151, 29);
            this.savePicturesButton.TabIndex = 12;
            this.savePicturesButton.Text = "Save Pictures";
            this.savePicturesButton.UseVisualStyleBackColor = true;
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(297, 43);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(151, 29);
            this.changePictureButton.TabIndex = 11;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.UseVisualStyleBackColor = true;
            // 
            // SaveCurveButton
            // 
            this.SaveCurveButton.Location = new System.Drawing.Point(297, 78);
            this.SaveCurveButton.Name = "SaveCurveButton";
            this.SaveCurveButton.Size = new System.Drawing.Size(151, 29);
            this.SaveCurveButton.TabIndex = 10;
            this.SaveCurveButton.Text = "Save Curve";
            this.SaveCurveButton.UseVisualStyleBackColor = true;
            // 
            // loadCurveButton
            // 
            this.loadCurveButton.Location = new System.Drawing.Point(297, 113);
            this.loadCurveButton.Name = "loadCurveButton";
            this.loadCurveButton.Size = new System.Drawing.Size(151, 29);
            this.loadCurveButton.TabIndex = 9;
            this.loadCurveButton.Text = "Load Curve";
            this.loadCurveButton.UseVisualStyleBackColor = true;
            // 
            // gcrButton
            // 
            this.gcrButton.Location = new System.Drawing.Point(143, 113);
            this.gcrButton.Name = "gcrButton";
            this.gcrButton.Size = new System.Drawing.Size(124, 29);
            this.gcrButton.TabIndex = 8;
            this.gcrButton.Text = "GCR";
            this.gcrButton.UseVisualStyleBackColor = true;
            // 
            // ucrButton
            // 
            this.ucrButton.Location = new System.Drawing.Point(143, 78);
            this.ucrButton.Name = "ucrButton";
            this.ucrButton.Size = new System.Drawing.Size(124, 29);
            this.ucrButton.TabIndex = 7;
            this.ucrButton.Text = "UCR";
            this.ucrButton.UseVisualStyleBackColor = true;
            // 
            // backtrack100Button
            // 
            this.backtrack100Button.Location = new System.Drawing.Point(143, 43);
            this.backtrack100Button.Name = "backtrack100Button";
            this.backtrack100Button.Size = new System.Drawing.Size(124, 29);
            this.backtrack100Button.TabIndex = 6;
            this.backtrack100Button.Text = "100% Backtrack";
            this.backtrack100Button.UseVisualStyleBackColor = true;
            // 
            // backtrack0Button
            // 
            this.backtrack0Button.Location = new System.Drawing.Point(143, 8);
            this.backtrack0Button.Name = "backtrack0Button";
            this.backtrack0Button.Size = new System.Drawing.Size(124, 29);
            this.backtrack0Button.TabIndex = 5;
            this.backtrack0Button.Text = "0% Backtrack";
            this.backtrack0Button.UseVisualStyleBackColor = true;
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
            this.blackRadioButton.Checked = true;
            this.blackRadioButton.Location = new System.Drawing.Point(8, 98);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(65, 24);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
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
            this.cyanRadioButton.Location = new System.Drawing.Point(9, 8);
            this.cyanRadioButton.Name = "cyanRadioButton";
            this.cyanRadioButton.Size = new System.Drawing.Size(62, 24);
            this.cyanRadioButton.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(552, 628);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(552, 366);
            this.splitContainer2.SplitterDistance = 273;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cyanPictureBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Panel2.Controls.Add(this.yellowPictureBox);
            this.splitContainer3.Size = new System.Drawing.Size(273, 366);
            this.splitContainer3.SplitterDistance = 180;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.magentaPictureBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.blackPictureBox);
            this.splitContainer4.Size = new System.Drawing.Size(275, 366);
            this.splitContainer4.SplitterDistance = 179;
            this.splitContainer4.TabIndex = 0;
            // 
            // cyanPictureBox
            // 
            this.cyanPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyanPictureBox.Location = new System.Drawing.Point(0, 0);
            this.cyanPictureBox.Name = "cyanPictureBox";
            this.cyanPictureBox.Size = new System.Drawing.Size(273, 180);
            this.cyanPictureBox.TabIndex = 0;
            this.cyanPictureBox.TabStop = false;
            // 
            // blackPictureBox
            // 
            this.blackPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackPictureBox.Location = new System.Drawing.Point(0, 0);
            this.blackPictureBox.Name = "blackPictureBox";
            this.blackPictureBox.Size = new System.Drawing.Size(275, 183);
            this.blackPictureBox.TabIndex = 1;
            this.blackPictureBox.TabStop = false;
            // 
            // yellowPictureBox
            // 
            this.yellowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yellowPictureBox.Location = new System.Drawing.Point(0, 0);
            this.yellowPictureBox.Name = "yellowPictureBox";
            this.yellowPictureBox.Size = new System.Drawing.Size(273, 182);
            this.yellowPictureBox.TabIndex = 2;
            this.yellowPictureBox.TabStop = false;
            // 
            // magentaPictureBox
            // 
            this.magentaPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.magentaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.magentaPictureBox.Name = "magentaPictureBox";
            this.magentaPictureBox.Size = new System.Drawing.Size(275, 179);
            this.magentaPictureBox.TabIndex = 3;
            this.magentaPictureBox.TabStop = false;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(552, 258);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 628);
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cyanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox bezierCanvas;
        private SplitContainer mainSplitContainer;
        private SplitContainer curveSsplitContainer;
        private Button saveAllPicturesButton;
        private Button blackAndWhiteButton;
        private Button savePicturesButton;
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
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private PictureBox mainPictureBox;
        private PictureBox cyanPictureBox;
        private PictureBox yellowPictureBox;
        private PictureBox magentaPictureBox;
        private PictureBox blackPictureBox;
    }
}