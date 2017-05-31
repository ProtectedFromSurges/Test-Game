using System;
using System.Collections.Generic;

namespace TestGame
{
	public class Game
	{
		public static State currentState = new State();

		public static void Launch()
		{
			UI.DrawBorder(@"..\\..\\Assets\\MainBorder.txt", 0, 0);
			UI.Update();
			TextController.AddOutput("Welcome to Test Game!");
			TextController.AddOutput("Please type START to start the game");
			currentState.CurrentLevel = 1;
			Update();		}

		public static void Update()
		{
			bool isRunning = true;
			while (isRunning)
			{
				// Running TextController update, and updating inputHistory in currentState
				TextController.Update();

				// Running the other updaters
				currentState.Update();
				UI.Update();
			}
		}
	}
}
