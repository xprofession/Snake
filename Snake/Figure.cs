using System;
using System.Collections.Generic;

namespace Snake
{
	public class Figure
	{
		protected List<Point> pList;

		protected int x;
		protected int y;
		protected char symb;

		public Figure()
		{
		}

		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.DrawPoint();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (Point p in pList)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		internal bool IsHit(Point point)
		{
			foreach (Point p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
