using System;
using System.Collections.Generic;

namespace TestGame
{
	public class Game
	{
		public static void Launch()
		{
			UI.DrawBorder(@"..\\..\\Assets\\MainBorder.txt", 0, 0);
			UI.Update();
			Update();
		}

		public static State currentState = new State();

		public static void Update()
		{
			bool isRunning = true;
			while (isRunning)
			{
				// Running TextController update, and updating inputHistory in currentState
				TextController.Update();

				// Running the other updaters
				currentState.Update();
				CommandParser.Update();
				UI.Update();
			}
		}
	}
}
