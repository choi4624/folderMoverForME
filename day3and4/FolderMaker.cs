using System.IO.Enumeration;

namespace day3and4
{
    internal class FolderMaker
    {
        private string[] outlet;

        public FolderMaker(string[] outlet)
        {
            this.outlet = outlet;
        }
        public string FolderString(string fileName)
        {
            //string inside = string.Empty; need to using .Distinct() method
            //var squareBracketsString = from filterName in fileName
            //                           let word = fileName.Split('[', ']')
            //                           where word.Length > 1
            //                           select word[1];

            //string dirName = string.Join("", squareBracketsString.Distinct());

            HashSet<string> uniqueResults = new HashSet<string>();

            var squareBracketsString = from filterName in fileName
                                       let words = fileName.Split('[', ']')
                                       where words.Length > 1 // Ensure there is content between '[' and ']'
                                       let content = words[1] // Access the content between square brackets
                                       where uniqueResults.Add(content) // Add to HashSet and filter out duplicates
                                       select content;

            string dirName = string.Join("", squareBracketsString);

            //Console.WriteLine(dirName);
            return dirName;
        }

        internal void MakeFolder(string returned, string sysdir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sysdir + "\\" + returned);
            if( !directoryInfo.Exists )
            {
                directoryInfo.Create();
            }
        }
    }
}