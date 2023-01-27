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

    //Method to test moodanalyser class return moodanalyser object
    [TestMethod]
    public void GivenMoodAnalyseClassNameReturnObject()
    {
        //Arrange
        string message = null;
        object expected = new MoodAnalyser(message);

        //Act
        object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");

        //Assert
        expected.Equals(obj);
    }

    //Method to test mood analyser with different class to return no class found
    [TestMethod]
    public void GivenClassWhenClassNameNotProperThrowException(string expected)
    {
        object obj = null;
        try
        {
            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
        }
        catch(MoodAnalyserCustomException actual)
        {
            //Assert
            Assert.AreEqual(expected, actual.Message);
        }
    }

    //Method to test mood analyse class return constructor not found
    [TestMethod]
    public void GivenClassWhenConstructorNotProperThrowException(string expected)
    {
        object obj = null;
        try
        {
            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
        }
        catch (MoodAnalyserCustomException actual)
        {
            //Assert
            Assert.AreEqual(expected, actual.Message);
        }
    }

    //Method to test mood analyser class with parameterized constructor 
    [TestMethod]
    public void GivenMessageReturnParameterizedConstructorNotFound()
    {
        object expected = new MoodAnalyser("HAPPY");
        object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "SAD");
        expected.Equals(obj);
    }

    //Method to use reflection to invoke method i.e analyse mood
    [TestMethod]
    public void GivenHappyMessageWhenProperShouldReturnHappy()
    {
        object expected = new MoodAnalyser("HAPPY");
        object actual = MoodAnalyserFactory.InvokeAnalyserMethod("Happy", "AnalyseMood");
        Assert.AreEqual(expected, actual);
    }
}
