using Spectre.Console;
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
            Author = AnsiConsole.Ask<string>("Enter the [green]author[/] of the book: ");
            Genre = AnsiConsole.Ask<string>("Enter the [green]genre[/] of the book: ");
        }

        public override void DisplayDetails()
        {
            AnsiConsole.Write(new Markup($"[bold]Book Details:[/] \n"));
            AnsiConsole.Write(new Markup($"[bold]Title:[/] {Title} \n"));
            AnsiConsole.Write(new Markup($"[bold]ID:[/] {Id} \n"));
            AnsiConsole.Write(new Markup($"[bold]Year Published:[/] {YearPublished} \n"));
            AnsiConsole.Write(new Markup($"[bold]Author:[/] {Author} \n"));
            AnsiConsole.Write(new Markup($"[bold]Genre:[/] {Genre} \n"));
        }
    }
}
