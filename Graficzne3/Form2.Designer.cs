namespace Graficzne3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cyanCanvas = new System.Windows.Forms.PictureBox();
            this.magentaCanvas = new System.Windows.Forms.PictureBox();
            this.yellowCanvas = new System.Windows.Forms.PictureBox();
            this.blackCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cyanCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 690);
            this.splitContainer1.SplitterDistance = 562;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cyanCanvas);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.yellowCanvas);
            this.splitContainer2.Size = new System.Drawing.Size(562, 690);
            this.splitContainer2.SplitterDistance = 330;
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
            this.splitContainer3.Panel1.Controls.Add(this.magentaCanvas);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.blackCanvas);
            this.splitContainer3.Size = new System.Drawing.Size(606, 690);
            this.splitContainer3.SplitterDistance = 330;
            this.splitContainer3.TabIndex = 0;
            // 
            // cyanCanvas
            // 
            this.cyanCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cyanCanvas.Location = new System.Drawing.Point(0, 0);
            this.cyanCanvas.Name = "cyanCanvas";
            this.cyanCanvas.Size = new System.Drawing.Size(562, 330);
            this.cyanCanvas.TabIndex = 0;
            this.cyanCanvas.TabStop = false;
            // 
            // magentaCanvas
            // 
            this.magentaCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.magentaCanvas.Location = new System.Drawing.Point(0, 0);
            this.magentaCanvas.Name = "magentaCanvas";
            this.magentaCanvas.Size = new System.Drawing.Size(606, 330);
            this.magentaCanvas.TabIndex = 1;
            this.magentaCanvas.TabStop = false;
            // 
            // yellowCanvas
            // 
            this.yellowCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yellowCanvas.Location = new System.Drawing.Point(0, 0);
            this.yellowCanvas.Name = "yellowCanvas";
            this.yellowCanvas.Size = new System.Drawing.Size(562, 356);
            this.yellowCanvas.TabIndex = 2;
            this.yellowCanvas.TabStop = false;
            // 
            // blackCanvas
            // 
            this.blackCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackCanvas.Location = new System.Drawing.Point(0, 0);
            this.blackCanvas.Name = "blackCanvas";
            this.blackCanvas.Size = new System.Drawing.Size(606, 356);
            this.blackCanvas.TabIndex = 3;
            this.blackCanvas.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 690);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cyanCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magentaCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource bindingSource1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private PictureBox cyanCanvas;
        private PictureBox yellowCanvas;
        private SplitContainer splitContainer3;
        private PictureBox magentaCanvas;
        private PictureBox blackCanvas;
    }
}