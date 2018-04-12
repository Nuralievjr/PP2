using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        bool Clicked;
        bool three;
        int x ;
        int y;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            Clicked = false;
            three = false;

            Rectangle[,] rects = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[i, j] = new Rectangle();
                    rects[i, j].Size = new Size(35, 35);
                    rects[i, j].Location = new Point(10 + j * 37, 10 + i * 37);
                    g.DrawRectangle(new Pen(Color.Black), rects[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle[,] rects = new Rectangle[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[i, j] = new Rectangle();
                    rects[i, j].Size = new Size(35, 35);
                    rects[i, j].Location = new Point(10 + j * 37, 10 + i * 37);
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rects[i, j]);
                    if (rects[i, j].Contains(x, y) && three == true)
                    {
                        
                        SolidBrush br = new SolidBrush(Color.Red);

                        e.Graphics.FillRectangle(br, rects[i, j]);
                        e.Graphics.FillRectangle(br, rects[i, j - 1]);
                        e.Graphics.FillRectangle(br, rects[i, j + 1]);
                    }


                }
            }
            pictureBox1.Refresh();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Clicked = true;
            Rectangle[,] rects = new Rectangle[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rects[i, j] = new Rectangle();
                    rects[i, j].Size = new Size(35, 35);
                    rects[i, j].Location = new Point(10 + j * 37, 10 + i * 37);
                    g.DrawRectangle(new Pen(Color.Black), rects[i, j]);
                    if (rects[i, j].Contains(x, y) && Clicked == true)
                    {
                        SolidBrush br = new SolidBrush(Color.Red);
                        g.FillRectangle(br, rects[i, j]);
                        g.FillRectangle(br, rects[i, j-1]);
                        g.FillRectangle(br, rects[i , j+1]);
                    }
                    


                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            x = e.X;
            y = e.Y;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            three = true;
        }
    }
}
