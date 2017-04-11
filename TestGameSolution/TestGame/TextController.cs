using System;
using System.Collections.Generic;

namespace TestGame
{
	public class TextController
	{
		public static string Update(List<string> inputHistory)
		{
			List<string> history = inputHistory;

			// Clear window
			for (int i = 0; i< 20; i++)
			{
				Console.SetCursorPosition(1, i + 1);
				Console.Write("                                                          ");
			}

			// Trimming input history, then printing
			if (history.Count > 18)
			{
				history.RemoveAt(0);
			}

			int count = 0;
			foreach (string line in history)
			{
				// Writing input history to game window
				Console.SetCursorPosition(4, 20 - history.Count + count);
				Console.Write(line);
				count++;
			}

			// Resetting command line and reading input
			Console.SetCursorPosition(4, 22);
			string input = Console.ReadLine();
			input = input.Trim();
			if (input.Length > 54)
			{
				// Trimming input
				input = input.Substring(0, 54);
			}

			return input;
		}
	}
}
