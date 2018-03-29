using System;

namespace LibraryCatalogue
{
    class Program
    {
        //hello from adam
        static void Main(string[] args)
        {
            createFile();




        }
        public static string createFile()
        {
            Console.WriteLine("Enter a file name");
            string fileName = Console.ReadLine();
            System.IO.File.Create(fileName);
            return fileName;
        }
        
    }
}
