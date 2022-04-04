using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyze
    {
        public string message;

        //Constructor part
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {

            if (message.Contains("Happy"))//Check string
            {
                return "Happy";//check message contain
            }
            else
            {
                return "Sad";//else part
            }

        }
    }

}
