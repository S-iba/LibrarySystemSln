using LibrarySystem.Classes;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LibrarySystem libSys = new LibrarySystem(); 
            int choice = 0;
            while (choice != 9)
            {
                Menu();
                switch ()
                {
                    case 1:
                        LibraryItem item = new();
                    default:
                }

            }
        }

        public static void Menu()
        {
            WriteLine("Welcome to  Virtual library\n");
            WriteLine("Please Choose below what you would like to do: \n");
            WriteLine("1. Add item \n2. Remove Item \n3. Search Item \n4. Display all Items");
            WriteLine("9. To Quit");
        }
    }
}
