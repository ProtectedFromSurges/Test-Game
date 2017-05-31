using System;
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

		int maxLevel = 1;
		private int _currentLevel;
		public int CurrentLevel
		{
			get
			{
				return _currentLevel;
			}
			set
			{
				if ((value <= maxLevel) && (value > 0))
				{
					_currentLevel = value;
				}
			}
		}

		private int _score = 0;
		public int Score
		{
			get;
			private set;
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

		public void AddHistory(List<string> historyToAdd)
		{
			foreach (string item in historyToAdd)
			{
				this.InputHistory.Add(item);
			}
		}

		public void Update()
		{
			
		}
	}
}
