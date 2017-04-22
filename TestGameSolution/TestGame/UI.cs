using System;
using System.Collections.Generic;

namespace TestGame
{
	public class UI
	{
		public static void DrawBorder(string pathToBorderFile, int cursorX, int cursorY)
		{
			// Reading border from .txt
			string[] border = System.IO.File.ReadAllLines(pathToBorderFile);
			Console.SetWindowSize(80, 24);

			// Printing border to console
			int currentLine = 0;
			foreach (string line in border)
			{
				Console.SetCursorPosition(cursorX, cursorY + currentLine);
				Console.Write(line);
				currentLine++;
			}
		}

		public static void Update()
		{
			// Resetting the border and sidebar, the main window is be cleared by the text controller
			string[] border = System.IO.File.ReadAllLines(@"..\\..\\Assets\\MainBorderUpdate.txt");
			int currentLine = 0;
			foreach (string line in border)
			{
				Console.SetCursorPosition(0, 0 + currentLine);
				Console.Write(line);
				currentLine++;
			}

			string[] sidebar = System.IO.File.ReadAllLines(@"..\\..\\Assets\\Sidebar.txt");
			currentLine = 0;
			foreach (string line in sidebar)
			{
				Console.SetCursorPosition(59, 0 + currentLine);
				Console.Write(line);
				currentLine++;
			}

			// Print current score and total score
			int[] score = Game.currentState.UIScore();
			if (score[0] <= score[1])
			{
				Console.SetCursorPosition(68, 6);
				Console.Write(score[0] + "/" + score[1]);
			}
			else
			{
				Console.SetCursorPosition(68, 6);
				Console.Write(score[0] + "/" + score[0]);
			}
		}
	}
}
