using System;
namespace MoodAnalyserProblem
{
	public class MoodAnalyser
	{
		public string message;

		//constructor to initialize message
		public MoodAnalyser(string message)
		{
			this.message = message;
		}

		//Method to analyse the mood from the given message
		public string AnalyseMood()
		{
			if (message.ToLower().Contains("sad"))
				return "sad";
			else
				return "happy";
		}
	}
}

