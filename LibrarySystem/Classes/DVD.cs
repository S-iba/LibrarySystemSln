using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Creating a new DVD item... \n");
            Console.Write("Enter the director of the DVD: ");
            Director = Console.ReadLine();
            Console.Write("Enter the duration of the DVD in minutes: ");
            Duration = int.Parse(Console.ReadLine());


        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"ID: {ID1}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Duration: {duration} minutes");
        }
    }
}
