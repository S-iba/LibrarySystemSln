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
            while (true) 
            {
                try
                {
                    Author = AnsiConsole.Ask<string>("Enter the [green]author[/] of the book: ");
                }
                catch (System.FormatException)
                {

                    Author = AnsiConsole.Ask<string>("[red]Invalid input. Please enter a valid author name:[/] ");
                }
                if (string.IsNullOrWhiteSpace(Author))
                {
                    Author = AnsiConsole.Ask<string>("[red]Author cannot be empty. Please enter a valid author name:[/] ");
                }
                else break;

            }
            
            while (true)
            {
                try
                {
                    Genre = AnsiConsole.Ask<string>("Enter the [green]genre[/] of the book: ");
                }
                catch (System.FormatException)
                {

                    Genre = AnsiConsole.Ask<string>("[red]Invalid input. Please enter a valid genre:[/] ");
                }
                if (string.IsNullOrWhiteSpace(Genre))
                {
                    Genre = AnsiConsole.Ask<string>("[red]Genre cannot be empty. Please enter a valid genre:[/] ");
                }
                else break;
            }
            
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
