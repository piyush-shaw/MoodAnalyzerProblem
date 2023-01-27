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
    [TestMethod]
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

    //Method to test happy message using null
    [TestMethod]
    public void GivenNullMoodShouldReturnHappy()
    {
        //Arrange
        string msg = null;
        string expected = "happy";
        string actual = null;
        MoodAnalyser mood = new MoodAnalyser(msg);

        //Act
        actual = mood.AnalyseMood();

        //Assert
        Assert.AreEqual(expected, actual);
    }

    //Method to test custom null exception message
    [TestMethod]
    public void GivenNullMoodThrowMoodAnalysisException()
    {
        //Arrange
        string msg = "";
        string expected = "Message should not be null";
        MoodAnalyser mood = new MoodAnalyser(msg);

        try
        {
            //Act
            string actual = mood.AnalyseMood();
        }
        catch(MoodAnalyserCustomException e)
        {
            //Assert
            Assert.AreEqual(expected, e.Message);
        }

    }

    //Method to test custom empty exception message 
    [TestMethod]
    public void GivenEmptyMoodThrowMoodAnalysisException()
    {
        //Arrange
        string msg = "";
        string expected = "Message should not be empty";
        MoodAnalyser mood = new MoodAnalyser(msg);

        try
        {
            //Act
            string actual = mood.AnalyseMood();
        }
        catch (MoodAnalyserCustomException e)
        {
            //Assert
            Assert.AreEqual(expected, e.Message);
        }

    }



















}
