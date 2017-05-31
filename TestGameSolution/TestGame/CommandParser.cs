﻿using System;
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
			switch (input[0])
			{
				case "score":
					Game.currentState.AddScore(1);
					TextController.AddOutput("Congratulations! Have a point!");
					break;
				case "secret":
					Game.currentState.AddScore(1, true);
					TextController.AddOutput("Looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
					                         "ooooooooooooooooooooooooooooooooooooooooooots of text");
					break;
				default:
					break;
			}

		}
	}
}
