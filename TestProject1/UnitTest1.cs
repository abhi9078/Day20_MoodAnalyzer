using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expexted = "Happy";
            string message = "I am in Happy Mood";
            MoodAnalyze moodA = new MoodAnalyze(message);//Parameterized constructor

            //Act
            string mood = moodA.AnalyzeMood();


            //Assert
            Assert.AreEqual(expexted, mood);
        }

    }
}
