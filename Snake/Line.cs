using System;
namespace Snake
{
	public class Line
	{
		int x;
		int y;
		int lenght;
		char symb;
		LineDirection direction;

		public Line(int _x, int _y, int _lenght, LineDirection _direction, char _symb)
		{
			x = _x;
			y = _y;
			lenght = _lenght;
			direction = _direction;
			symb = _symb;
			Draw();
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			if (direction == LineDirection.Horizontal)
			{
				for (int i = 0; i < lenght; i++)
				{
					Console.Write(symb);
				}
			}
			else if (direction == LineDirection.Vertical)
			{
				for (int i = 0; i < lenght; i++)
				{
					Console.SetCursorPosition(x, y + i);
					Console.Write(symb);
				}
			}
		}

		public enum LineDirection
		{
			Horizontal,
			Vertical
		}
	}
}
