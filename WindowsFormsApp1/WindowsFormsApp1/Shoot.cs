using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    class Shoot
    {
        int x, y;
        
        public GraphicsPath g;
        public Shoot() { }

        public enum Direction
        {
            UP,
            DOWN,
            RIGHT,
            LEFT
           
        };
        public Direction direction;
        public Shoot(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            Fire();
        }

        public void Fire()
        {   
            if(direction== Direction.RIGHT)
            {
                x++;
                g = new GraphicsPath();
                g.AddLine(x, y, x +1, y);
            }
            if (direction == Direction.DOWN)
            {
                y++;
                g = new GraphicsPath();
                g.AddLine(x, y, x , y+1);
            }
            if (direction == Direction.UP)
            {
                y--;
                g = new GraphicsPath();
                g.AddLine(x, y, x , y-1);
            }
            if (direction == Direction.LEFT)
            {
                x--;
                g = new GraphicsPath();
                g.AddLine(x, y, x-1, y);
            }

        }
       
    }
}
