using System;
namespace Snake
{
    public class Food
    {
        public Point location;
        public string sign;
        public ConsoleColor color;
        public Food()
        {

            color = ConsoleColor.White;
            sign = "&";
            RandomFood();

        }
        public void RandomFood()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 20);
            location = new Point(x, y);
        }

        public void Setup()
        {
            
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}
