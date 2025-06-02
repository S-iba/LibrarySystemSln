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
            //Console.WriteLine("Creating a new magazine item... \n");
            Console.Write("Enter the issue number of the magazine: ");
            IssueNumber = Console.ReadLine();
            Console.Write("Enter the month the magazine was published (1-12): ");
            MonthPublished = int.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            //writeline specific to Magazine
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"ID: {ID1}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Issue Number: {issueNumber}");
            Console.WriteLine($"Month published: {monthPublished}");
        }
    }
}
