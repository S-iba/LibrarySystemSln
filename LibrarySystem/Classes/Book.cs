using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.Classes
{
    internal class Book : LibraryItem
    {
        private string author;
        private string genre;

        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }

        public Book() : base()
        {
            Console.WriteLine("Creating a new book item... \n");
            Console.Write("Enter the author of the book: ");
            Author = Console.ReadLine();
            Console.Write("Enter the genre of the book: ");
            Genre = Console.ReadLine();
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"ID: {ID1}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
