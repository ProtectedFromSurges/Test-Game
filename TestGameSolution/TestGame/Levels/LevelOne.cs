using System;
namespace TestGame
{
	public class CommandParser
	{
		public static void Update()
		{
			string[] input = Game.currentState.LastInput.Split(' ');

			// Somehow handle commands, maybe checking the first part of input?
			// Then have the commands call another class? Result.Update()??????

			// Do a test score command first, + secret
			switch (input[0].ToLower())
			{
				case "score":
					Game.currentState.AddScore(1);
					TextController.AddOutput("Congratulations! Have a point!");
					break;
				case "secret":
					Game.currentState.AddScore(1, true);
					TextController.AddOutput("Very sneaky, well done");
					break;
				case "start":
					// Launch level 1?
					TextController.AddOutput("In the future, this will launch the game");
					TextController.AddOutput("Thanks for playing!");
					break;
				default:
					TextController.AddOutput("I don't recognise that command, try again");
					break;
			}

		}
	}
}
