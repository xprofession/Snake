using System;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			MainClass main = new MainClass();
			main.StartGame();
		}

		public void StartGame()
		{ 
			Score score = new Score();
			score.PrintScore();
			Walls walls = new Walls(81, 25);
			walls.Draw();

			//Initializing Snake
			Point tail = new Point(4, 5, '*');
			Snake snake = new Snake(tail, 3, Direction.Right);
			snake.Draw();
			snake.PrintSpeed();

			FoodGenerator foodGenerator = new FoodGenerator(78, 23, '#');
			Point food = foodGenerator.CreateFood(snake);
			food.DrawPoint();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					if (Score.score > Score.maxScore)
						Score.maxScore = Score.score;
					score.PrintGameOver();
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.SetCursorPosition(39, 16);
					while (true)
					{
						if (Console.KeyAvailable)
						{
							ConsoleKeyInfo key = Console.ReadKey();
							if (key.Key == ConsoleKey.Y)
							{
								Console.Clear();
								Score.score = 0;
								StartGame();
							}
							else if (key.Key == ConsoleKey.N)
								Environment.Exit(0);
							else
								Console.Write("");
						}
					}
				}

				if (snake.Eat(food))
				{
					food = foodGenerator.CreateFood(snake);
					food.DrawPoint();
					score.PrintScore();
					snake.PrintSpeed();
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
