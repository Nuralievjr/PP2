using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class Tank
    {
        public int x, y;
        public int w, h;
        public int speed;
        public GraphicsPath gp;
        public Tank(int x, int y, int w, int h, int speed)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.speed = speed;
            
            Up();
            Down();
            Right();
            Left();
        }
       
        
        public void Up()
        {
            y = y - speed;
            gp = new GraphicsPath();          
            gp.AddRectangle(new Rectangle(x, y, w, h));        
            gp.AddEllipse(new Rectangle(x, y, w, h));
            gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y - h / 2);
        }
        public void Down()
        {
            y = y + speed;
            gp = new GraphicsPath();          
            gp.AddRectangle(new Rectangle(x, y, w, h));          
            gp.AddEllipse(new Rectangle(x, y, w, h));
            gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h + h / 2);
        }
        public void Right()
        {
            x = x + speed;
            gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x, y, w, h));
            gp.AddLine(x + w / 2, y + h / 2, x + w + w / 2, y + h / 2);
            
        }
        public void Left()
        {

            x = x - speed;
            gp = new GraphicsPath();
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x, y, w, h));
            gp.AddLine(x + w / 2, y + h / 2, x - w / 2, y + h / 2);
        }
        
    }
}
