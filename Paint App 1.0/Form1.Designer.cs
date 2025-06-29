namespace Paint_App_1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panTools = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCanColor = new System.Windows.Forms.Button();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.cmbBrushSize = new System.Windows.Forms.ComboBox();
            this.txtShapeSize = new System.Windows.Forms.TextBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cleartoolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoOnPaintApp = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.Panel();
            this.panTools.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTools
            // 
            this.panTools.BackColor = System.Drawing.Color.Maroon;
            this.panTools.Controls.Add(this.label7);
            this.panTools.Controls.Add(this.label1);
            this.panTools.Controls.Add(this.label6);
            this.panTools.Controls.Add(this.label5);
            this.panTools.Controls.Add(this.label2);
            this.panTools.Controls.Add(this.btnCanColor);
            this.panTools.Controls.Add(this.btnBrushColor);
            this.panTools.Controls.Add(this.cmbBrushSize);
            this.panTools.Controls.Add(this.txtShapeSize);
            this.panTools.Controls.Add(this.btnCircle);
            this.panTools.Controls.Add(this.btnRect);
            this.panTools.Controls.Add(this.btnSquare);
            this.panTools.Location = new System.Drawing.Point(0, 21);
            this.panTools.Name = "panTools";
            this.panTools.Size = new System.Drawing.Size(942, 145);
            this.panTools.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(267, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter Shape Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Shape";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color Of Canvas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Brush Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brush Size";
            // 
            // btnCanColor
            // 
            this.btnCanColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnCanColor.Location = new System.Drawing.Point(46, 39);
            this.btnCanColor.Name = "btnCanColor";
            this.btnCanColor.Size = new System.Drawing.Size(32, 28);
            this.btnCanColor.TabIndex = 4;
            this.btnCanColor.UseVisualStyleBackColor = false;
            this.btnCanColor.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.BackColor = System.Drawing.Color.Black;
            this.btnBrushColor.Location = new System.Drawing.Point(46, 108);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(32, 28);
            this.btnBrushColor.TabIndex = 2;
            this.btnBrushColor.UseVisualStyleBackColor = false;
            this.btnBrushColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBrushSize
            // 
            this.cmbBrushSize.FormattingEnabled = true;
            this.cmbBrushSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbBrushSize.Location = new System.Drawing.Point(188, 44);
            this.cmbBrushSize.Name = "cmbBrushSize";
            this.cmbBrushSize.Size = new System.Drawing.Size(42, 21);
            this.cmbBrushSize.TabIndex = 1;
            this.cmbBrushSize.Text = "1";
            // 
            // txtShapeSize
            // 
            this.txtShapeSize.Location = new System.Drawing.Point(294, 45);
            this.txtShapeSize.Name = "txtShapeSize";
            this.txtShapeSize.Size = new System.Drawing.Size(64, 20);
            this.txtShapeSize.TabIndex = 9;
            this.txtShapeSize.Text = "10";
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.SystemColors.Control;
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(503, 45);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(68, 47);
            this.btnCircle.TabIndex = 7;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.SystemColors.Control;
            this.btnRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRect.BackgroundImage")));
            this.btnRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRect.Location = new System.Drawing.Point(418, 44);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(68, 47);
            this.btnRect.TabIndex = 6;
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.Control;
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(577, 44);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(68, 47);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cleartoolstrip,
            this.exitToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Cleartoolstrip
            // 
            this.Cleartoolstrip.Name = "Cleartoolstrip";
            this.Cleartoolstrip.Size = new System.Drawing.Size(101, 22);
            this.Cleartoolstrip.Text = "Clear";
            this.Cleartoolstrip.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(101, 22);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoOnPaintApp});
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolStrip.Text = "Help";
            // 
            // InfoOnPaintApp
            // 
            this.InfoOnPaintApp.Name = "InfoOnPaintApp";
            this.InfoOnPaintApp.Size = new System.Drawing.Size(199, 22);
            this.InfoOnPaintApp.Text = "About Paint application";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Canvas.Location = new System.Drawing.Point(0, 163);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(942, 527);
            this.Canvas.TabIndex = 2;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasDrawMouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasDrawMouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasDrawMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 689);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.panTools);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Application 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panTools.ResumeLayout(false);
            this.panTools.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTools;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ComboBox cmbBrushSize;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.ToolStripMenuItem Cleartoolstrip;
        private System.Windows.Forms.Button btnCanColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShapeSize;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem InfoOnPaintApp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

