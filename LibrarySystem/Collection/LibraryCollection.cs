using LibrarySystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;
using static System.Console;
using Spectre.Console;

namespace LibrarySystem.Collection
{
    internal class LibraryCollection
    {
        private List<LibraryItem> itemList;
        // creating an instance of the list >>>>>
        public LibraryCollection() {
        
            itemList = new List<LibraryItem>();
        }
        //Method to add a record - - - - - -
        public void AddItem() 
        {


            string choice = string.Empty;
            while (choice != "Quit")
            {
                choice = Menu();
                //Write("Please enter your choice: ");
                //choice = int.Parse(ReadLine());
                switch (choice)
                {
                    case "Book":
                        Book book = new Book();
                        itemList.Add(book);
                        break;
                    case "Magazine":
                        Magazine magazine = new Magazine();
                        itemList.Add(magazine);
                        break;
                    case "DVD":
                        DVD dvd = new DVD();
                        itemList.Add(dvd);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Item has been successfully added");
        }
        // Method to search by id ---- also used to in removing...
        public int SearchById(string Id)
        {
            Console.WriteLine("Item could not be found...");
            return -1;
        }
        //Method to remove item by ID
        public void RemoveItem(string Id)
        {
            if (SearchById(Id) != -1)
            {
                itemList.RemoveAt(SearchById(Id));
            }else
            {
                Console.WriteLine("No changes made...");
            }
        }
        //Display method to be called by the Main method
        public void DisplayAll()
        {
            foreach (var item in itemList)
            {
                item.DisplayDetails();
            }
        }

        //Menu
        private string Menu()
        {
            //WriteLine("Please enter the type of item you would like to Add: ");
            //WriteLine("1. Book \n2. Magazine \n3. DVD");
            string choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold blue]Welcome to the Virtual Library[/]")
                    .PageSize(10)
                    .AddChoices(new[] { "Book", "Magazine", "DVD", "Quit" }));
            return choice;
        }
    }
}
