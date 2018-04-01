using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LibraryCatalogue
{
    public class CardCatalogue
    {


        private string _fileName;

        public CardCatalogue(string fileName)
        {
            _fileName = fileName;
        }

        List<Book> books = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Please enter a title");
            string Title = Console.ReadLine();
            Book myBook = new Book();
            myBook.Title = Title;
            books.Add(myBook);

            Console.WriteLine("Please enter an author");
            string Author = Console.ReadLine();            
            myBook.Author = Author;
            books.Add(myBook);

            Console.WriteLine("Please enter a year");
            int Year = Convert.ToInt32(Console.ReadLine());
            myBook.Year = Year;
            books.Add(myBook);

            Console.WriteLine("Please enter a genre");
            string Genre = Console.ReadLine();
            myBook.Genre = Genre;
            books.Add(myBook);

            Console.WriteLine("Please enter a language");
            string Language = Console.ReadLine();
            myBook.Language = Language;
            books.Add(myBook);

        }
        
        public void ListBooks()
        {
            Console.WriteLine("List of books:");
            foreach (Book b in books )
            {
                Console.WriteLine(b);
            }
        }

        public void Save()
        {

        }
    }
}
