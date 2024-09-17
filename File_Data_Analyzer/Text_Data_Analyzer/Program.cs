namespace File_Data_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To File Analayzer Application");
            Console.WriteLine("Enter your File Pathe");

            string inputFolderPath = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);

            if (directoryInfo.Exists == false)
            {
                Console.WriteLine("File not Existed");
                return;
            }
         var filenames=directoryInfo.GetFiles();
            //do not know what type of file i shouid analyse
            IFileAnalysis ifileAnalysis = null;
            foreach (var file in filenames) 
            {
                if (file.IsTextFile())
                {
                    //when i know
                    ifileAnalysis = new TextFileAnalyzer();
                    ifileAnalysis.AnalyzeFile(file);
                    //  Convert from interface to fileAnalyzer class to get Result
                    var results = ((FileAnalyzer)ifileAnalysis).GetResult();
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Words : {results.WordCount}");
                    Console.WriteLine($"Charachter count : {results.CharchterCount}");
                    Console.WriteLine($"Line Count : {results.LineCount}");
                }
                else if (file.IsCsvFile()) 
                {
                    ifileAnalysis = new CsvFileAnalyzer();
                    ifileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)ifileAnalysis).GetResult();
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Fields count: {results.FieldCount}");
                   
                }

            }
        }
    }
}
