using System;
namespace TestGame
{
	public class CommandParser
	{
		public static void Update()
		{
			string input = Game.currentState.LastInput;

			// Somehow handle commands, maybe checking the first part of input?
			// Then have the commands call another class? Result.Update()??????

			// Do a test score command first, + secret

			// Checking the length of lastInput before each check, to avoid an exception
			/*if (lastInput.Lenth() >= 6)
			{
				switch (lastInput.Substring(0, 6))
				{
					case "secret":
						
				}
			}*/
		}
	}
}
