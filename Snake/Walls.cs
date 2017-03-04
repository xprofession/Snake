using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
	public class Walls
	{
		List<Figure> wallsList;

		public Walls(int mapWidth, int mapHeight)
		{
			wallsList = new List<Figure>();

			//Borders
			Line topLine = new Line(1, 0, mapWidth - 2, Line.LineDirection.Horizontal, '+');
			Line bottomLine = new Line(1, mapHeight - 1, mapWidth - 2, Line.LineDirection.Horizontal, '+');
			Line leftLine = new Line(0, 1, mapHeight - 1, Line.LineDirection.Vertical, '+');
			Line rightLine = new Line(mapWidth - 2, 1, mapHeight - 1, Line.LineDirection.Vertical, '+');



			wallsList.Add(topLine);
			wallsList.Add(bottomLine);
			wallsList.Add(leftLine);
			wallsList.Add(rightLine);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (Figure wall in wallsList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (Figure wall in wallsList)
			{
				wall.Draw();
			}
		}
	}
}
