using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem
{
	public class MoodAnalyserFactory
	{
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }

        //Method to create Mood Analyser Object Using Reflection
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            //Matching the pattern for extension of namespace
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }

    }
}

