using System;
namespace Snake
{
	public class Point
	{
		int x;
		int y;
		char symb;

		public Point(int _x, int _y, char _symb)
		{
			x = _x;
			y = _y;
			symb = _symb;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			symb = p.symb;
		}

		public void DrawPoint()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(symb);
		}

		public void MovePoint(int offset, Direction direction)
		{
			if (direction == Direction.Right)
				x = x + offset;
			if (direction == Direction.Left)
				x = x - offset;
			if (direction == Direction.Up)
				y = y + offset;
			if (direction == Direction.Down)
				y = y - offset;
		}

		public void ClearPoint()
		{
			symb = ' ';
			DrawPoint();
		}
}
}
