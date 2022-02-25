using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//practicing c# re-writing the code from https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-6.0

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            
            //Write each directory name to file.
            using (StreamWriter sw = new StreamWriter("CDriverDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }
            //Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}