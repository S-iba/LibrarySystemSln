using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;
using LibrarySystem.Collection;
using static System.Console;
using Spectre.Console;

namespace LibrarySystem.Classes
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public int YearPublished { get; set; }

        LibraryCollection shelf = new LibraryCollection();

        public LibraryItem() {
            AnsiConsole.Clear();
            AnsiConsole.Write(new Markup("[bold blue]Library System![/] \n"));

            while (true)
            {
                try
                {
                    Id = AnsiConsole.Ask<string>("Enter the [green]ID[/] of the item: ");
                }
                catch (System.FormatException e)
                {
                    Id = AnsiConsole.Ask<string>("[red]Invalid input. Please enter a valid ID:[/] ");
                }
                if (string.IsNullOrWhiteSpace(Id))
                {
                    Id = AnsiConsole.Ask<string>("[red]ID cannot be empty. Please enter a valid ID:[/] ");
                }
                else break;
            }

            while (true)
            {
                try
                {
                    Title = AnsiConsole.Ask<string>("Enter the [green]title[/] of the item: ");
                }
                catch (System.FormatException e)
                {
                    Title = AnsiConsole.Ask<string>("[red]Invalid input. Please enter a valid title:[/] ");
                }
                if (string.IsNullOrWhiteSpace(Title))
                {
                    Title = AnsiConsole.Ask<string>("[red]Title cannot be empty. Please enter a valid title:[/] ");
                }
                else break;
            }
            while (true)
            {
                try
                {
                    YearPublished = AnsiConsole.Ask<int>("Enter the [green]year published[/] of the book: ");
                }
                catch (System.FormatException e)
                {
                    YearPublished = AnsiConsole.Ask<int>("[red]Invalid input. Please enter a valid year:[/] ");
                }
                if (YearPublished < 1450 || YearPublished > DateTime.Now.Year)
                {
                    YearPublished = AnsiConsole.Ask<int>("[red]Year must be between 1450 and the current year. Please enter a valid year:[/] ");
                }
                else break;
            }



        }

        public abstract void DisplayDetails();// required writeline for every class
    }
}
