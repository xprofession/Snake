using System;
using System.Threading;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Walls walls = new Walls(80, 25);
			walls.Draw();

			//Initializing Snake
			Point tail = new Point(4, 5, '*');
			Snake snake = new Snake(tail, 3, Direction.Right);
			snake.Draw();

			FoodGenerator foodGenerator = new FoodGenerator(78, 23, '#');
			Point food = foodGenerator.CreateFood();
			food.DrawPoint();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}

				if (snake.Eat(food))
				{
					food = foodGenerator.CreateFood();
					food.DrawPoint();
				}
				else
				{
					snake.Move();
				}

				//Thread.Sleep(100);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.KeyHandler(key.Key);
				}
			}
		}
	}
}
