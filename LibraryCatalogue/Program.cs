using System;

namespace LibraryCatalogue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            createFile();
            int choice =
                PromptUserForNumber(
                    string.Format("Would you like to 1.LIst all Books, 2.Add a book, or 3.Save and Exit ?"));
            //need to write methods in CardCatalog
            if (choice == 1)
            {
                CardCatalogue.ListBooks();
            }
            else if (choice == 2)
            {
                CardCatalogue.AddBook();
            }
            else if (choice == 3)
            {
                CardCatalogue.Save();
            }

        }
        public static string createFile()
        {
            Console.WriteLine("Enter a file name");
            string fileName = Console.ReadLine();
            System.IO.File.Create(fileName);
            return fileName;
        }
        private static int PromptUserForNumber(string promptString = "Enter a number")
        {
            int num;
            string input = "";
            while (!int.TryParse(input, out num))
            {
                Console.WriteLine(promptString);
                input = Console.ReadLine();
            }

            return num;
        }




    }
}
