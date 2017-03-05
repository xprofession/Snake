using System;
namespace Snake
{
	public class Score
	{
		public static int maxScore;
		public static int score = 0;

		public Score()
		{
		}

		public void PrintScore()
		{
			Console.SetCursorPosition(65, 0);
			Console.Write("Score: " + score);
		}

		public void PrintGameOver()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(0, 2);
			Console.Write("                    ________________________________________                    ");
			Console.Write("                   |                                        |                   ");
			Console.Write("                   |            The game is over            |                   ");
			Console.Write("                   |            Your score: " + score);
			Console.SetCursorPosition(60, 5);
			Console.Write("|                   ");
			Console.Write("                   |                                        |                   ");
			Console.Write("                   |              Max Score:                |                   ");
			Console.Write("                   |                   " + maxScore);
			Console.SetCursorPosition(60, 8);
			Console.Write("|                   ");
			Console.Write("                   |                                        |                   ");
			Console.Write("                   |                                        |                   ");
			Console.Write("                   |              Play again?               |                   ");
			Console.Write("                   |                  Y/N                   |                   ");
			Console.Write("                   |                                        |                   ");
			Console.Write("                   |________________________________________|                   ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
			Console.Write("                                                                                ");
		}
}
}
