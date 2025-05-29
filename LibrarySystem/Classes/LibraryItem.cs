using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;
using static System.Console;


namespace LibrarySystem.Classes
{
    internal class LibraryItem
    {
        private string title;
        private string ID;
        private int yearPublished;

        public string Title { get => title; set => title = value; }
        public string ID1 { get => ID; set => ID = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }

        public LibraryItem() {
            
            WriteLine("Creating a new library item... \n");
            WriteLine("Please enter the details below: \n");
            Write("Enter the title of the item: ");
            title = ReadLine();
            Write("\nEnter the ID of the item: ");
            ID = ReadLine();
            Write("\nEnter the year the item was published: ");
            yearPublished = int.Parse(ReadLine());
        }
    }
}
