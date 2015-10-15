using System;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Draw (1, 2, 'E');
			Draw (1, 3, 'L');

		}


		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (sym);
		}
	}
}
