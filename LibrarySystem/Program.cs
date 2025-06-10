using LibrarySystem.Classes;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;
using LibrarySystem.Collection;
using Spectre.Console;  

namespace LibrarySystem
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            LibraryCollection shelf = new LibraryCollection();// instance of the collections class

            string choice = string.Empty;
            while (choice != "Quit")
            {
               
                //Write("Please enter your choice: ");
                choice =  Menu();
                
                switch (choice)
                {   
                    case "Add Item":
                        shelf.AddItem();
                        break;
                    case "Remove Item":
                        Write("Please enter the ID you would like to remove: ");
                        string ID = ReadLine();
                        shelf.RemoveItem(ID);
                        break;
                    case "Search Item":
                        Write("Please enter the ID you would like to search: ");
                        string search = ReadLine();
                        shelf.SearchById(search);
                        break;
                    case "Display All Items":
                        shelf.DisplayAll();
                        break;
                    default:
                        break;
                }
            }
        }
        // menu template to be re-used
        public static string Menu()
        {
            //WriteLine("Welcome to  Virtual library\n");
            //WriteLine("Please Choose below what you would like to do: \n");
            //WriteLine("1. Add item \n2. Remove Item \n3. Search Item \n4. Display all Items");
            //WriteLine("9. To Quit");
            //AnsiConsole.Ask<string>("[bold blue]Welcome to virtual Library" +
            //    "\nPlease choose below:[/]" +
            //    "\n[bold yellow]1. Add item \n2. Remove Item \n3. Search Item \n4. Display all Items" +
            //    "\n9. To Quit[/]");
            string choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold blue]Welcome to the Virtual Library[/]")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Add Item",
                        "Remove Item",
                        "Search Item",
                        "Display All Items",
                        "Quit"
                    }));
            return choice;
        }
    }
}
