using System;
namespace TestGame
{
	public class LevelOne
	{
		public static void Update()
		{
			// Grabs the latest input from InputHistory and splits it
			string lastInput = Game.currentState.InputHistory[Game.currentState.InputHistory.Count - 1];
			string[] input = lastInput.Split(' ');

			// Checking input against all commands for the level
			switch (input[0].ToLower())
			{
				case "score":
					// Add a check for repeats with real commands
					Game.currentState.AddScore(1);
					TextController.AddOutput("Congratulations! Have a point!");
					break;
				case "secret":
					Game.currentState.AddScore(1, true);
					TextController.AddOutput("Very sneaky, well done");
					break;
				case "start":
					TextController.AddOutput("You are in a spaceship???");
					break;
				default:
					TextController.AddOutput("I don't recognise that command, try again");
					break;
			}

		}
	}
}
