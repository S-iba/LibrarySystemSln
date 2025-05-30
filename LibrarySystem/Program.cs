using LibrarySystem.Classes;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;
using LibrarySystem.Collection;

namespace LibrarySystem
{
    internal class Program
    {
        LibraryCollection shelf = new LibraryCollection();
        static void Main(string[] args)
        {
            
            int choice = 0;
            while (choice != 9)
            {
                Menu();
                try
                {
                    choice = int.Parse(ReadLine());
                }
                catch (Exception e)
                {

                    throw;
                }
                switch (choice)
                {   
                   
                    case 1:
                        //AddMenu();
                        break;
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

        public void AddMenu()
        {
            WriteLine("Please enter the type of item you would like to Add: ");
            WriteLine("1. Book \n2. Magazine \n3. DVD");

            int choice = 0;
            while (choice != 9)
            {
                switch (choice)
                {   
                    case 1:
                        Book book = new Book();
                        shelf.AddItem(book);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
