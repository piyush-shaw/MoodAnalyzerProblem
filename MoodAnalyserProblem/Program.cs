using MoodAnalyserProblem;

internal class Program
{
    public static string msg = null;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Analyser Problem !!! ");

        //Calling the mood analyser object
        MoodAnalyser mood = new MoodAnalyser(msg);
        string resMood = mood.AnalyseMood();
        Console.WriteLine(resMood);
    }
}