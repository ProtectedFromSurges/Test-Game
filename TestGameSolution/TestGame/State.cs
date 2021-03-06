﻿using System;
using System.Collections.Generic;

namespace TestGame
{
	public class State
	{
		// History of the players input, used for printing to window and
		// grabbing the latest input
		private List<string> _inputHistory = new List<string>();
		public List<string> InputHistory
		{
			get
			{
				return _inputHistory;
			}
			set
			{
				_inputHistory = value;
			}
		}

		private int _score = 0;
		public int Score
		{
			get
			{
				return _score;
			}
			private set
			{
				_score = value;
			}
		}

		// Maximum score
		int scoreSecret = 1;
		public int scoreMaximum
		{
			get;
			private set;
		} = 1;

		public void AddScore(int pointsToAdd)
		{
			// Checks score against maximum, then adds it
			if (this.Score + pointsToAdd > scoreMaximum)
			{
				throw new Exception("Player score exceeds maximum score");
			}
			else
			{
				Score += pointsToAdd;
			}
		}

		public void AddScore(int pointsToAdd, bool isSecret)
		{
			// Checks score against maximum, then adds it
			if (this.Score + pointsToAdd > scoreMaximum + scoreSecret)
			{
				throw new Exception("Player secret score exceeds maximum score");
			}
			else
			{
				Score += pointsToAdd;
				scoreMaximum += pointsToAdd;
				scoreSecret -= pointsToAdd;
			}
		}

		// Latest player input
		private string _lastInput;
		public string LastInput
		{
			get
			{
				return _lastInput;
			}
			private set
			{
				_lastInput = value;
			}
		}

		public void AddHistory(List<string> historyToAdd)
		{
			foreach (string item in historyToAdd)
			{
				this.InputHistory.Add(item);
			}
		}

		public void Update()
		{
			// Grabs the latest input from InputHistory
			this.LastInput = this.InputHistory[this.InputHistory.Count - 1];
		}
	}
}
