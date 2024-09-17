using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Data_Analyzer
{
    public class FileAnalyzer
    {
        //Base Class
        private AnalysisResult _Result;
        public AnalysisResult GetResult()
        {
            return _Result;   
        }
        public void SetResult(AnalysisResult Result)
        { 
            //validation
          _Result = Result;
        }
    }
}
