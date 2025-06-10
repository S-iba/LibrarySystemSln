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
            while (choice != "Back")
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
            Console.Write(new Markup("[green]Item has been successfully added"));
        }
        // Method to search by id ---- also used to in removing...
        public int SearchById(string Id)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].Id == Id)
                {
                    AnsiConsole.Write(new Markup($"[green]Item with ID {Id} has been found.[/]"));
                    //itemList[i].DisplayDetails();
                    return i;
                }
            }
            return -1;
        }
        //Method to remove item by ID
        public void RemoveItem(string Id)
        {
            if (SearchById(Id) != -1)
            {
                string choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title($"[bold blue]Are you sure you want to remove the item with ID {Id}?[/]")
                        .AddChoices(new[] { "Yes", "No" }));
                if (choice == "No")
                {
                    AnsiConsole.Write(new Markup($"[red]Item with ID {Id} will not be removed.[/]"));
                    return;
                }
                else
                {
                    AnsiConsole.Write(new Markup($"[green]Item with ID {Id} has been found and will be removed.[/]"));
                    itemList.RemoveAt(SearchById(Id));
                }
                   
            }else
            {
                AnsiConsole.Write(new Markup($"[red]Item with ID {Id} could not be found.[/]"));
            }
        }
        //Display method to be called by the Main method
        public void DisplayAll()
        {
            foreach (var item in itemList)
            {
                AnsiConsole.WriteLine();
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
                    .AddChoices(new[] { "Book", "Magazine", "DVD", "Back" }));
            return choice;
        }
    }
}
