using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCatalogue
{
    public class CardCatalogue
    {
    

        private string fileName;

        List<string> books = new List<string>();

        public void AddBook()
        {
            Console.WriteLine("Please enter a title");
            string title = Console.ReadLine();
            books.Add(title);
        }
        


        public void ListBooks()
        {
            Console.WriteLine("List of books:");
            foreach (string b in books )
            {
                Console.WriteLine(b);
            }
        }
      
    }
}
