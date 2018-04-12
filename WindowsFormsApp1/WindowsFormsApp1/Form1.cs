using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Tank tank;
        Shoot shoot;
        Bitmap bmpstone;
        Bitmap bmpwater;
        bool UP, DOWN, RIGHT, LEFT = false;
        bool FireRight, FireUP, FireDown, FireLeft = false;
        List<Shoot> listofshoot;     
        List<PictureBox> listofstone;
        List<PictureBox> listofwater;
        List<Rectangle> collisionineverystone;
        List<Rectangle> collisioninwater;


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            
            tank = new Tank(50, 50, 50, 50,4);
            shoot = new Shoot(tank.x + tank.w + tank.w / 2, tank.y + tank.h / 2,Shoot.Direction.RIGHT);
            listofshoot = new List<Shoot>();
            listofstone = new List<PictureBox>();
            listofwater = new List<PictureBox>();
            collisionineverystone = new List<Rectangle>();
            collisioninwater = new List<Rectangle>();
            bmpstone = new Bitmap("C://Users//Rau//Desktop//Stone.png");
            bmpwater = new Bitmap("C://Users//Rau//Desktop//Water.png");
            g = Graphics.FromImage(bmpwater);
            StreamReader sr = new StreamReader(@"C:\Users\Rau\Desktop\StoneandWater.txt");
            int n = int.Parse(sr.ReadLine());
            PictureBox Stone = new PictureBox();
            PictureBox Water = new PictureBox();
            for (int i = 0; i<n;i++)
            {
                string s = sr.ReadLine();
                for(int j=0;j<s.Length;j++)
                {
                    if (s[j] =='1')
                    {
                        Stone = new PictureBox();
                        Rectangle c = new Rectangle();               
                        collisionineverystone.Add(c);                       
                        Stone.Location = new Point(j*8, i*15);
                        Stone.Size = new Size(75, 75);
                        Stone.Image = bmpstone;
                        Stone.SizeMode = PictureBoxSizeMode.StretchImage;
                        Controls.Add(Stone);
                        listofstone.Add(Stone);
                    }
                    if(s[j]=='0')
                    {
                        Water = new PictureBox();
                        Rectangle w = new Rectangle();
                        collisioninwater.Add(w);
                        Water.Location = new Point(j * 8, i * 15);
                        Water.Size = new Size(75, 75);
                        Water.Image = bmpwater;
                        Water.SizeMode = PictureBoxSizeMode.StretchImage;
                        Controls.Add(Water);
                        listofwater.Add(Water);
                    }
                }
            }
            for(int i = 0;i<listofstone.Count;i++)
            {
                collisionineverystone[i] = new Rectangle(listofstone[i].Location.X, listofstone[i].Location.Y, listofstone[i].Size.Width, listofstone[i].Size.Height);
            }
            for(int i = 0;i<listofwater.Count;i++)
            {
                collisioninwater[i] = new Rectangle(listofwater[i].Location.X, listofwater[i].Location.Y, listofwater[i].Size.Width,listofwater[i].Size.Height);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawPath(new Pen(Color.Blue,3), tank.gp);
            g.DrawPath(new Pen(Color.Red, 4), shoot.g);
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
           if(UP==true)
            {
                tank.Up();
                g.Clear(Color.Black);
                g.DrawPath(new Pen(Color.Blue, 3), tank.gp);
                tank.speed = 4;
                for (int i = 0; i < collisionineverystone.Count; i++)
                {
                    if (collisionineverystone[i].Contains(tank.x + tank.w / 2, tank.y - tank.h / 2))
                    {
                        tank.speed = 0;
                    }
                }
                for (int i = 0; i < collisioninwater.Count; i++)
                {
                    if (collisioninwater[i].Contains(tank.x + tank.w / 2, tank.y - tank.h / 2))
                    {
                        tank.speed = 1;
                    }
                }

            }
            if (DOWN == true)
            {
                tank.Down();
                g.Clear(Color.Black);
                g.DrawPath(new Pen(Color.Blue, 3), tank.gp);
                tank.speed = 4;
                for (int i = 0; i < collisionineverystone.Count; i++)
                {
                    if (collisionineverystone[i].Contains(tank.x + tank.w / 2, tank.y + tank.h + tank.h / 2))
                    {
                        tank.speed = 0;
                    }
                }
                for (int i = 0; i < collisioninwater.Count; i++)
                {
                    if (collisioninwater[i].Contains(tank.x + tank.w / 2, tank.y + tank.h + tank.h / 2))
                    {
                        tank.speed = 1;
                    }
                }

            }
            if (RIGHT == true)
            {
                tank.Right();
                g.Clear(Color.Black);
                g.DrawPath(new Pen(Color.Blue, 3), tank.gp);
                tank.speed = 4;
                for (int i = 0; i < collisionineverystone.Count; i++)
                {
                    if (collisionineverystone[i].Contains(tank.x + tank.w + tank.w / 2, tank.y + tank.h / 2))
                    {
                        tank.speed = 1;
                    }
                }
                for (int i = 0; i < collisioninwater.Count; i++)
                {
                    if (collisioninwater[i].Contains(tank.x + tank.w + tank.w / 2, tank.y + tank.h / 2))
                    {
                        tank.speed = 1;
                    }
                }

            }
            if (LEFT == true)
            {
                tank.Left();
                g.Clear(Color.Black);
                g.DrawPath(new Pen(Color.Blue, 3), tank.gp);
                tank.speed = 4;
                for (int i = 0; i < collisionineverystone.Count; i++)
                {
                    if (collisionineverystone[i].Contains(tank.x - tank.w / 2, tank.y + tank.h / 2))
                    {
                        tank.speed = 0;
                    }
                }
                for (int i = 0; i < collisioninwater.Count; i++)
                {
                    if (collisioninwater[i].Contains(tank.x - tank.w / 2, tank.y + tank.h / 2))
                    {
                        tank.speed = 1;
                    }
                }
            }
            if(FireRight==false)
            {
                shoot = new Shoot(tank.x + tank.w + tank.w / 2, tank.y + tank.h / 2,Shoot.Direction.RIGHT);              
            }          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (FireRight == true)
            {
                foreach (Shoot shoot in listofshoot)
                {
                   shoot.Fire();                 
                   g.DrawPath(new Pen(Color.Red, 4), shoot.g);
                }
            }
            if (FireUP == true)
            {
                foreach (Shoot shoot in listofshoot)
                {
                    shoot.Fire();
                    g.DrawPath(new Pen(Color.Red, 4), shoot.g);
                }
            }
            if (FireDown == true)
            {
                foreach (Shoot shoot in listofshoot)
                {
                    shoot.Fire();
                    g.DrawPath(new Pen(Color.Red, 4), shoot.g);
                }
            }
            if (FireLeft == true)
            {
                foreach (Shoot shoot in listofshoot)
                {
                    shoot.Fire();              
                    g.DrawPath(new Pen(Color.Red, 4), shoot.g);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                DOWN = false;
                UP = true;
                LEFT = false;
                RIGHT = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                DOWN = true;
                UP = false;
                LEFT = false;
                RIGHT = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                RIGHT = true;
                DOWN = false;
                UP = false;
                LEFT = false;
                
            }
            if (e.KeyCode == Keys.Left)
            {
                LEFT = true;
                DOWN = false;
                UP = false;          
                RIGHT = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                if(RIGHT==true)
                {
                    shoot = new Shoot(tank.x + tank.w + tank.w / 2, tank.y + tank.h / 2,Shoot.Direction.RIGHT);
                    listofshoot.Add(shoot);
                    FireRight = true;
                }
                if (UP==true)
                {
                    shoot = new Shoot(tank.x + tank.w / 2, tank.y - tank.h / 2,Shoot.Direction.UP);
                    listofshoot.Add(shoot);
                    FireUP = true;                 
                }
                if (DOWN == true)
                {
                    shoot = new Shoot(tank.x + tank.w / 2, tank.y + tank.h + tank.h / 2, Shoot.Direction.DOWN);
                    listofshoot.Add(shoot);
                    FireDown = true;
                }
                if (LEFT == true)
                {
                    shoot = new Shoot(tank.x - tank.w / 2, tank.y + tank.h / 2, Shoot.Direction.LEFT);
                    listofshoot.Add(shoot);
                    FireLeft = true;
                }
            }
        }
    }
}
