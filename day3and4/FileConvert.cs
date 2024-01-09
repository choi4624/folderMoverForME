using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace day3and4
{
    class FileConvert
    {
        static void Main(string[] args)
        {
            // system directory setting 
            string sysdir = Console.ReadLine(); 
            if (sysdir == null)
            {
                sysdir = "\\.";
            }
            
            // filelist extract (incude extension) 
            var input = new FileConvert();
            string[] outlet = input.DirectoryList(sysdir);
            foreach (var item in outlet)
            {
                Console.WriteLine(item);
            }

            // this is code first [] inside output like "Touyoko Surfrider (Fummy)"
            var folderMake = new FolderMaker(outlet);
            List<string> stringList = new List<string>();
            foreach (var item in outlet)
            {
                string returned = folderMake.FolderString(item);
                Console.WriteLine(returned);
                stringList.Add(returned);

                // here to make folder
                folderMake.MakeFolder(returned, sysdir);
            }

            //move the code and folder 
            int i = 0; 
            foreach (var item in outlet) 
            {
                var move = new FileMove(outlet, stringList);
                move.FileMoving(stringList[i], item, sysdir );
                i++;
            }
            i = 0;

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }
        }
        public string[] DirectoryList(string path)
        {
                DirectoryInfo DirectoryInfo = new DirectoryInfo(path);

                FileInfo[] fileInfos = DirectoryInfo.GetFiles();
                string[] strings = new string[fileInfos.Length];
                StringBuilder sb = new StringBuilder();
                int i = 0;
                foreach (FileInfo file in fileInfos) { strings[i] = Path.GetFileName(file.Name); i++; }
                return strings;
        }

        public FileConvert() {
            
        }
    }
}
