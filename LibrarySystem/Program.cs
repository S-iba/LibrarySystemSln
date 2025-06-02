using LibrarySystem.Classes;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;
using LibrarySystem.Collection;

namespace LibrarySystem
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
             LibraryCollection shelf = new LibraryCollection();
            int choice = 0;
            while (choice != 9)
            {
                Menu();
                try
                {
                    choice = int.Parse(ReadLine());
                }
                catch (System.FormatException e)
                {
                    WriteLine("Please enter a valid number...");
                }
                switch (choice)
                {   
                   
                    case 1:
                        shelf.AddItem();
                        break;
                    case 2:
                        Write("Please enter the ID you would like to remove: ");
                        string ID = ReadLine();
                        shelf.RemoveItem(ID);
                        break;
                    case 3:
                        Write("Please enter the ID you would like to search: ");
                        string search = ReadLine();
                        shelf.SearchById(search);
                    default:
                        break;
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

        public static void AddMenu()
        {
            

            
        }
    }
}
