using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Data_Analyzer
{
    public class CsvFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] FileString = File.ReadAllLines(fileInfo.FullName);
           var RowElemnt = FileString[0].Split(',');
            AnalysisResult result = new AnalysisResult();
            result.FieldCount = RowElemnt.Length;
            SetResult(result);

        }
    }
}
