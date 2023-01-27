using MoodAnalyserProblem;

namespace MoodAnalyserMSTest;

[TestClass]
public class UnitTest1
{
    //Method to test sad message 
    [TestMethod]
    public void AnalyseMood_ShouldReturnSad()
    {
        //Arrange
        string msg = "I am in Sad Mood";
        string expected = "sad";
        MoodAnalyser mood = new MoodAnalyser(msg);

        //Act
        string actual = mood.AnalyseMood();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    //Method to test happy message
    public void AnalyseMood_ShouldReturnHappy()
    {
        //Arrange
        string msg = "I am in Any Mood";
        string expected = "happy";
        MoodAnalyser mood = new MoodAnalyser(msg);

        //Act
        string actual = mood.AnalyseMood();

        //Assert
        Assert.AreEqual(expected, actual);
    }
}
