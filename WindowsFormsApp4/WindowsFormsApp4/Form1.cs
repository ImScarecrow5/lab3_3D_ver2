using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawKochButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                PointF start = new PointF(50, pictureBox.Height - 100);
                PointF end = new PointF(pictureBox.Width - 50, pictureBox.Height - 100);
                DrawKoch(g, start, end, 4); // глубина 4
            }
            pictureBox.Image = bmp;
        }

        private void DrawKoch(Graphics g, PointF p1, PointF p2, int depth)
        {
            if (depth == 0)
            {
                g.DrawLine(Pens.Black, p1, p2);
            }
            else
            {
                float dx = p2.X - p1.X;
                float dy = p2.Y - p1.Y;
                float thirdX = dx / 3;
                float thirdY = dy / 3;
                PointF pA = new PointF(p1.X + thirdX, p1.Y + thirdY);
                PointF pB = new PointF(p1.X + 2 * thirdX, p1.Y + 2 * thirdY);
                float angle = (float)Math.Atan2(dy, dx) - (float)(Math.PI / 3);
                float len = (float)Math.Sqrt(thirdX * thirdX + thirdY * thirdY);
                float peakX = pA.X + len * (float)Math.Cos(angle);
                float peakY = pA.Y + len * (float)Math.Sin(angle);
                PointF peak = new PointF(peakX, peakY);
                DrawKoch(g, p1, pA, depth - 1);
                DrawKoch(g, pA, peak, depth - 1);
                DrawKoch(g, peak, pB, depth - 1);
                DrawKoch(g, pB, p2, depth - 1);
            }
        }
    }
}