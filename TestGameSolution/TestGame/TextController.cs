using System;
using System.Collections.Generic;

namespace TestGame
{
	public class TextController
	{
		public static void Update()
		{
			List<string> history = Game.currentState.InputHistory;

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
			history.Add(input);

			Game.currentState.InputHistory = history;
		}

		public static void AddOutput(string textToAdd)
		{
			List<string> listToAdd = new List<string>();
			string text = textToAdd;

			// Splitting output into multiple lines if necessary
			while (text.Length > 54)
			{
				listToAdd.Add(text.Substring(0, 54));
				text = text.Substring(54);
			}
			// Adding the remaining text
			listToAdd.Add(text);

			// Adding all the lines to the input history (should probably change that name now)
			Game.currentState.InputHistory.AddRange(listToAdd);
		}
	}
}
