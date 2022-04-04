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
            string expexted = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyze moodA = new MoodAnalyze(message);//Parameterized constructor

            //Act
            string mood = moodA.AnalyzeMood();


            //Assert
            Assert.AreEqual(expexted, mood);
        }

    }
}
