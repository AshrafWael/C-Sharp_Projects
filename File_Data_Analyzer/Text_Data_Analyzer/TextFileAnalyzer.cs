using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Data_Analyzer
{
    public class TextFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string FileString = File.ReadAllText(fileInfo.FullName);

            AnalysisResult result = new AnalysisResult();

            var Words = FileString.Split(new char[]{' ','\n','\r'});

            result.WordCount = Words.Length;

            result.CharchterCount= FileString.Length;

            var Lines = FileString.Split(new char[] {'\n'});

            result.LineCount = Lines.Length;

            SetResult(result);

        }
    }
} 
