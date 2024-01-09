namespace day3and4
{
    internal class FileMove
    {
        private string[] outlet;
        private List<string> paths;
        public FileMove(string[] outlet, List<string> paths)
        {
            this.outlet = outlet;
            this.paths = paths;
        }
        public void FileMoving(string newfolder, string fileName, string sysdir)
        {
            FileInfo file = new FileInfo(sysdir + "\\" + fileName);
            if(file.Exists)
            {
                Console.WriteLine(sysdir + "\\" + newfolder +"\\"+ fileName);
                file.MoveTo(sysdir + "\\" + newfolder+"\\"+fileName);
            }
        }
    }
}