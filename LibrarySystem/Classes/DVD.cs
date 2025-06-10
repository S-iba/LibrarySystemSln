using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace LibrarySystem.Classes
{
    internal class DVD : LibraryItem
    {
        private string director;
        private int duration;//in mins

        public string Director { get => director; set => director = value; }
        public int Duration { get => duration; set => duration = value; }

        public DVD() : base()
        {

            // Using AnsiConsole for better user interaction
            // Using AnsiConsole for better user input experience
            director = AnsiConsole.Ask<string>("Enter the [green]director[/] of the DVD: ");
            duration = AnsiConsole.Ask<int>("Enter the [green]duration[/] of the DVD in minutes: ");


        }

        public override void DisplayDetails()
        {
            AnsiConsole.Write(new Markup($"[bold]DVD Details:[/] \n"));
            AnsiConsole.Write(new Markup($"[bold]Title:[/] \n"));
            AnsiConsole.Write(new Markup($"[bold]ID:[/] {Id} \n"));
            AnsiConsole.Write(new Markup($"[bold]Year Published:[/] {YearPublished} \n"));
            AnsiConsole.Write(new Markup($"[bold]Director:[/] {Director} \n"));
            AnsiConsole.Write(new Markup($"[bold]Duration:[/] {Duration} minutes \n"));
        }
    }
}
