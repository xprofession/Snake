using System;
namespace Snake
{
	public class FoodGenerator
	{
		int mapWidth;
		int mapHeight;
		char symb;

		Random random = new Random();

		public FoodGenerator(int mapWidth, int mapHeight, char symb)
		{
			this.mapWidth = mapWidth;
			this.mapHeight = mapHeight;
			this.symb = symb;
		}

		public Point CreateFood(Figure figure)
		{
			while (true)
			{
				int x = random.Next(2, mapWidth - 2);
				int y = random.Next(2, mapHeight - 2);
				Point p = new Point(x, y, symb);
				if (!figure.IsHit(p))
				{
					return p;
				}
			}
		}
	}
}
