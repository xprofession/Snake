using System;

namespace Snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Line topLine = new Line(1, 0, 78, Line.LineDirection.Horizontal, '-');
			Line bottomLine = new Line(1, 24, 78, Line.LineDirection.Horizontal, '-');
			Line leftLine = new Line(0, 1, 23, Line.LineDirection.Vertical, '|');
			Line RightLine = new Line(79, 1, 23, Line.LineDirection.Vertical, '|'); 
			Console.ReadKey();
		}
	}
}
