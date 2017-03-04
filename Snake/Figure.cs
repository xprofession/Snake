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
	}
}
