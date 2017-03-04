using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
	public class Snake : Figure
	{
		Direction direction;

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

			if (direction == Direction.Up || direction == Direction.Down)
			{
				Thread.Sleep(200);
			}
			else
			{
				Thread.Sleep(150);
			}
		}

		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.MovePoint(1, direction);
			return nextPoint;
		}

		public void KeyHandler(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow && direction != Direction.Right)
				direction = Direction.Left;
			else if (key == ConsoleKey.RightArrow && direction != Direction.Left)
				direction = Direction.Right;
			else if (key == ConsoleKey.UpArrow && direction != Direction.Down)
				direction = Direction.Up;
			else if (key == ConsoleKey.DownArrow && direction != Direction.Up)
				direction = Direction.Down;
		}

		internal bool Eat(Point food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.symb = head.symb;
				pList.Add(food);
				return true;
			}
			else
			{
				return false;
			}
		}

		internal bool IsHitTail()
		{
			Point head = pList.Last();
			for (int i = 0; i < pList.Count - 2; i++)
			{
				if (head.IsHit(pList[i]))
					return true;
			}
			return false;
		}
	}
}
