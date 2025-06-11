using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibrarySystem.Classes
{
    internal class Magazine : LibraryItem
    {
        private string issueNumber;
        private int monthPublished;

        public string IssueNumber { get => issueNumber; set => issueNumber = value; }
        public int MonthPublished { get => monthPublished; set => monthPublished = value; }

        public Magazine() : base()
        {
            // Using AnsiConsole for better user interaction
            while (true)
            {
                issueNumber = AnsiConsole.Ask<string>("Enter the [green]issue number[/] of the magazine: ");
                if (string.IsNullOrWhiteSpace(issueNumber))
                {
                    AnsiConsole.MarkupLine("[red]Issue number cannot be empty. Please try again.[/]");
                    continue;
                }
                else break;
            }
            monthPublished = AnsiConsole.Prompt<int>(new SelectionPrompt<int>()
                .Title("[bold blue]Select a month below[/]: ")
                .PageSize(10)
                .AddChoices(new[]
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
                })); ;
        }

        public override void DisplayDetails()
        {
            AnsiConsole.Write(new Markup($"[bold]Magazine Details:[/] \n"));
            AnsiConsole.Write(new Markup($"[bold]Title:[/] {Title} \n"));
            AnsiConsole.Write(new Markup($"[bold]ID:[/] {Id} \n"));
            AnsiConsole.Write(new Markup($"[bold]Year Published:[/] {YearPublished} \n"));
            AnsiConsole.Write(new Markup($"[bold]Issue Number:[/] {IssueNumber} \n"));
            AnsiConsole.Write(new Markup($"[bold]Month Published:[/] {MonthPublished} \n"));
        }
    }
}
