using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{   
    
    class MainClass
    {   
       

        public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            StreamWriter save = new StreamWriter(@"/Users/macbook/Documents/PP2/Savage.txt");
            int level = 1;
            int nextlevel = 0;
            int score = 1;

            Snake snake = new Snake();
            Wall wall = new Wall(level);
            Food food = new Food();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            while (true)
            {   
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                    



                if (snake.CollisionWithWall(wall))
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("GAME OVER!!!!");
                    Console.ReadKey();
                    snake = new Snake();
                    wall = new Wall(level);
                }




                if(snake.CollisionWithFood(food))
                {
                    food.RandomFood();
                    nextlevel++;
                }
                if(nextlevel == 3)
                {
                    score++;
                    level++;
                    wall = new Wall(level);
                    nextlevel = 0;
                    snake = new Snake();
                    food = new Food();
                }
                if(snake.CollisionWithWall(wall))
                {
                    save.WriteLine(username + " " + score * nextlevel);
                    save.Close();
                }

                Console.Clear();
                snake.Draw();
                wall.Draw();
                food.Setup(); 
                //Console.WriteLine(score*nextlevel);

            }

        }
    }
}
