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
			//Handling Exception if user provide null value
			try
			{
				if (message.ToLower().Contains("sad"))
					return "sad";
				else
					return "happy";
			}
			catch (NullReferenceException)
			{
				return "happy";
			}
		}
	}
}

