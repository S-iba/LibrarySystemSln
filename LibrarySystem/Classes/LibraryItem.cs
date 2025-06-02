using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;
using LibrarySystem.Collection;
using static System.Console;


namespace LibrarySystem.Classes
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }
        public string ID1 { get; set; }
        public int YearPublished { get; set; }

        LibraryCollection shelf = new LibraryCollection();

        public LibraryItem() {
            
            WriteLine("Creating a new library item... \n");
            WriteLine("Please enter the details below: \n");
            Write("Enter the title of the item: ");
            Title = ReadLine();
            Write("\nEnter the ID of the item: ");
            ID1 = ReadLine();
            Write("\nEnter the year the item was published: ");
            YearPublished = int.Parse(ReadLine());
        }

        public abstract void DisplayDetails();// required writeline for every class
    }
}
