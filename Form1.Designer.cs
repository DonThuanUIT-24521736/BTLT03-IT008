namespace _24521736_BTLT03
{
    partial class Form1
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
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.lblShapes = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.txtTextToDraw = new System.Windows.Forms.TextBox();
            this.lblTextToDraw = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.gbTextOptions = new System.Windows.Forms.GroupBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.gbTextOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.btnClear);
            this.pnlTool.Controls.Add(this.btnColor);
            this.pnlTool.Controls.Add(this.cmbShapes);
            this.pnlTool.Controls.Add(this.numThickness);
            this.pnlTool.Controls.Add(this.lblShapes);
            this.pnlTool.Controls.Add(this.lblThickness);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTool.Location = new System.Drawing.Point(943, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(239, 653);
            this.pnlTool.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 90);
            this.label1.TabIndex = 8;
            this.label1.Text = "draw geometric shapes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(5, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 51);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(3, 449);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(109, 41);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cmbShapes
            // 
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Location = new System.Drawing.Point(87, 113);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(149, 24);
            this.cmbShapes.TabIndex = 5;
            this.cmbShapes.SelectedIndexChanged += new System.EventHandler(this.cmbShapes_SelectedIndexChanged);
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(110, 385);
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(91, 22);
            this.numThickness.TabIndex = 4;
            this.numThickness.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.BackColor = System.Drawing.Color.Lime;
            this.lblShapes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShapes.Location = new System.Drawing.Point(4, 117);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(66, 20);
            this.lblShapes.TabIndex = 2;
            this.lblShapes.Text = "Shapes: ";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.BackColor = System.Drawing.Color.Lime;
            this.lblThickness.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThickness.Location = new System.Drawing.Point(4, 384);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(85, 20);
            this.lblThickness.TabIndex = 1;
            this.lblThickness.Text = "Thickness: ";
            // 
            // txtTextToDraw
            // 
            this.txtTextToDraw.Location = new System.Drawing.Point(0, 56);
            this.txtTextToDraw.Name = "txtTextToDraw";
            this.txtTextToDraw.Size = new System.Drawing.Size(233, 22);
            this.txtTextToDraw.TabIndex = 3;
            this.txtTextToDraw.WordWrap = false;
            // 
            // lblTextToDraw
            // 
            this.lblTextToDraw.AutoSize = true;
            this.lblTextToDraw.BackColor = System.Drawing.Color.Lime;
            this.lblTextToDraw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextToDraw.Location = new System.Drawing.Point(3, 33);
            this.lblTextToDraw.Name = "lblTextToDraw";
            this.lblTextToDraw.Size = new System.Drawing.Size(105, 20);
            this.lblTextToDraw.TabIndex = 0;
            this.lblTextToDraw.Text = "Text To Draw:";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Left;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(940, 653);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // gbTextOptions
            // 
            this.gbTextOptions.Controls.Add(this.chkUnderline);
            this.gbTextOptions.Controls.Add(this.chkItalic);
            this.gbTextOptions.Controls.Add(this.chkBold);
            this.gbTextOptions.Controls.Add(this.lblTextToDraw);
            this.gbTextOptions.Controls.Add(this.txtTextToDraw);
            this.gbTextOptions.Location = new System.Drawing.Point(943, 155);
            this.gbTextOptions.Name = "gbTextOptions";
            this.gbTextOptions.Size = new System.Drawing.Size(236, 192);
            this.gbTextOptions.TabIndex = 9;
            this.gbTextOptions.TabStop = false;
            this.gbTextOptions.Text = "Text Options";
            this.gbTextOptions.Visible = false;
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(8, 155);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(95, 24);
            this.chkUnderline.TabIndex = 6;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(8, 125);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(63, 24);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(8, 95);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(63, 24);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.gbTextOptions);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.pnlTool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.gbTextOptions.ResumeLayout(false);
            this.gbTextOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.TextBox txtTextToDraw;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblTextToDraw;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTextOptions;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
    }
}

