using System;
using System.Collections.Generic;
namespace Snake
{
	public class Line : Figure
	{
		LineDirection direction;
		int lenght;

		public Line(int _x, int _y, int _lenght, LineDirection _direction, char _symb)
		{
			pList = new List<Point>();
			if (_direction == LineDirection.Horizontal)
			{
				for (int x = _x; x < _lenght; x++)
				{
					Point p = new Point(x, _y, _symb);
					pList.Add(p);
  				}
			}
			else if (_direction == LineDirection.Vertical)
			{
				for (int y = _y; y < _lenght; y++)
				{
					Point p = new Point(_x, y, _symb);
					pList.Add(p);
				}
			}
			//x = _x;
			//y = _y;
			//lenght = _lenght;
			//direction = _direction;
			//symb = _symb;
		}

		public enum LineDirection
		{
			Horizontal,
			Vertical
		}
	}
}
