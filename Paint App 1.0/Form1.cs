using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dw = Canvas.CreateGraphics();
        }
        bool startPaint = false;
        Graphics dw;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        int? initX = null;
        int? initY = null;
        private void CanvasDrawMouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                Pen p = new Pen(btnBrushColor.BackColor, float.Parse(cmbBrushSize.Text));
                dw.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
        private void CanvasDrawMouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                SolidBrush sb = new SolidBrush(btnBrushColor.BackColor);
                dw.FillRectangle(sb, e.X, e.Y, int.Parse(txtShapeSize.Text), int.Parse(txtShapeSize.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btnBrushColor.BackColor);
                dw.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txtShapeSize.Text), int.Parse(txtShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btnBrushColor.BackColor);
                dw.FillEllipse(sb, e.X, e.Y, int.Parse(txtShapeSize.Text), int.Parse(txtShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }
        private void CanvasDrawMouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btnBrushColor.BackColor = c.Color;
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dw.Clear(Canvas.BackColor);
            Canvas.BackColor = Color.White;
            btnCanColor.BackColor = Color.White;
        }
        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                Canvas.BackColor = c.Color;
                btnCanColor.BackColor = c.Color;
            }
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LETS CLOSE THIS APP", "Goodbye", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}