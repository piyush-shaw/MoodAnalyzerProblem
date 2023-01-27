using System;
namespace MoodAnalyserProblem
{
	public class MoodAnalyserCustomException:Exception
	{
		public ExceptionType type;

		//Using enum to differentiate the mood analysis error
		public enum ExceptionType
		{
			NULL_MESSAGE,
			EMPTY_MESSAGE
		}

		//Constructor to initialize the enum exception types
		public MoodAnalyserCustomException(ExceptionType type,string message) : base(message)
		{
			this.type = type;
		}
	}
}

