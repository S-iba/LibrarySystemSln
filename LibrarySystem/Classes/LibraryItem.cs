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
            Title = AnsiConsole.Ask<string>("Enter the [green]title[/] of the item: ");
            Id = AnsiConsole.Ask<string>("Enter the [green]ID[/] of the item: ");
            YearPublished = AnsiConsole.Ask<int>("Enter the [green]year published[/] of the item: ");


        }

        public abstract void DisplayDetails();// required writeline for every class
    }
}
