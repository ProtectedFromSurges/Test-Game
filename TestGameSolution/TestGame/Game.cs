using System;
using System.Collections.Generic;

namespace TestGame
{
	public class Game
	{
		public static void Launch()
		{
			UI.DrawBorder(@"C:\\Users\\sh515\\Documents\\Projects\\TestGameSolution\\TestGame\\Assets\\MainBorder.txt", 0, 0);
			Update();
		}

		// Move state to this class

		public static void Update()
		{
			State currentState = new State();

			bool isRunning = true;
			while (isRunning)
			{
				// This will be added to the input history
				List<string> historyToAdd = new List<string>();

				// Running TextController update, and updating inputHistory in currentState
				historyToAdd.Add(TextController.Update(currentState.InputHistory));

				// Running the other updaters
				currentState.Update();
				historyToAdd.Add(CommandParser.Update(currentState.LastInput));
				UI.Update(currentState.UIScore());
			}
		}
	}
}
