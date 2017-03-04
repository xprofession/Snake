using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
	public class Snake : Figure
	{
		public Direction direction;

		public Snake(Point tail, int lenght, Direction _direction)
		{
			direction = _direction;
			pList = new List<Point>();
			for (int i = 0; i < lenght; i++)
			{
				Point p = new Point(tail);
				p.MovePoint(i, direction);
				pList.Add(p);
			}
		}

		internal void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.ClearPoint();
			head.DrawPoint();
		}

		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.MovePoint(1, direction);
			return nextPoint;
		}
	}
}
