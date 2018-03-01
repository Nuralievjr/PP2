using System;
namespace Snake
{
    public class Game
    {
        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public static bool GameOver;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 20);

            GameOver = false;

            snake = new Snake();
            food = new Food();
            wall = new Wall();
        }
        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Setup();
            wall.Draw();


           
        }

    }
}
