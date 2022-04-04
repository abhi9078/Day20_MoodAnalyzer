using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyze
    {
        
        public string AnalyzeMood(string message)
        {

            if (message.Contains("SAD"))//Check string
            {
                return "SAD";//check message contain
            }
            else
            {
                return "HAPPY";
            }

        }
    }

}
