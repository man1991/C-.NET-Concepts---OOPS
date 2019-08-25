using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_Folders_SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: To create a directory
            //Directory.
            //    CreateDirectory
            //    (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram");

            //Step 2: Create File and write single line. WriteAllText - writes single text/line
            //File.
            //    WriteAllText
            //    (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\Some.txt",
            //    "Hello");

            //Step 3: Create File and write multiple lines. WriteAllLines - writes multiple lines or full array to file
            //string[] arr = { "one", "two", "Three" }; 
            //File.
            //    WriteAllLines
            //    (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\Some.txt",
            //    arr);

            //Step 4: Reading folders and files
            //To view all the directories
            //string[] dir = Directory.
            //    GetDirectories(@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\");

            //foreach(string strD in dir)
            //{
            //    Console.WriteLine(strD);

            //    string[] files = Directory.GetFiles(strD);//To view all files in directory
            //    foreach (string strF in files)
            //    {
            //        Console.WriteLine(strF);
            //    }
            //}

            //Step 5: Read file content
            //ReadAllText - To read all data in a single string but we cannot loop through this strings.
            //string str = File.
            //    ReadAllText
            //    (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\Some.txt");
            //Console.WriteLine(str);

            //To read all data in array
            //ReadLines - To read all data into an array and we can loop through this strings.
            //IEnumerable<string> str = File.
            //    ReadLines
            //    (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\Some.txt");
            //foreach(string s in str)
            //{
            //    Console.WriteLine(s);
            //}

            //Step 6: File Info provides information and nature of file
            //FileInfo f = new FileInfo(@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\Some.txt");
            //Console.WriteLine(f.Exists);
            //Console.WriteLine(f.Extension);

            //Step 6: Directory Info provides information and nature of directories
            DirectoryInfo d = new DirectoryInfo
                (@"G:\Projects\Questpond\Fundamentals\DotNet_Fundamentals\Files_Folders_SystemIO\CreatedFromProgram\");
            Console.WriteLine(d.Exists);
            Console.WriteLine(d.LastAccessTime);
            Console.ReadLine();
        }
    }
}
