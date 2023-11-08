using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp.Forms
{
    public partial class FormMain : Form
    {
        Graphics graphics;
        Boolean isCursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        public FormMain()
        {
            InitializeComponent();
            graphics = pnlCanvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, 7);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pbBlack_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isCursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isCursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(cursorX!=-1 && cursorY!=-1 && isCursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }
    }
}
