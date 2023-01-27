using System;
namespace MoodAnalyserProblem
{
	public class MoodAnalyser
	{
		public string message;

		//default constructor
        public MoodAnalyser()
        {
        }

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
				//In case of null or empty mood throw custom exception
				if (message.Equals(null))
					throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Message should not be null");
				else if (message.Equals(string.Empty))
					throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Message should not be empty");
				else if(message.ToLower().Contains("sad"))
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

