using System;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Borders
			Line topLine = new Line(1, 0, 78, Line.LineDirection.Horizontal, '-');
			Line bottomLine = new Line(1, 24, 78, Line.LineDirection.Horizontal, '-');
			Line leftLine = new Line(0, 1, 23, Line.LineDirection.Vertical, '|');
			Line rightLine = new Line(79, 1, 23, Line.LineDirection.Vertical, '|');
			topLine.Draw();
			bottomLine.Draw();
			leftLine.Draw();
			rightLine.Draw();

			//Initializing Snake
			Point tail = new Point(4, 5, '*');
			Snake snake = new Snake(tail, 3, Direction.Right);
			snake.Draw();
			snake.Move();

			Console.ReadKey();
		}
	}
}
