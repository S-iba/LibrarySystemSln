using LibrarySystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;
using static System.Console;

namespace LibrarySystem.Collection
{
    internal class LibraryCollection
    {
        private List<LibraryItem> itemList;
        // creating an instance of the list >>>>>
        public LibraryCollection() {
        
            itemList = new List<LibraryItem>();
        }
        //Method to add a record - - - - - -
        public void AddItem() 
        {
            WriteLine("Please enter the type of item you would like to Add: ");
            WriteLine("1. Book \n2. Magazine \n3. DVD");

            int choice = 0;
            while (choice != 9)
            {
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
                        Book book = new Book();
                        itemList.Add(book);
                        break;
                    case 2:
                        Magazine magazine = new Magazine();
                        itemList.Add(magazine);
                        break;
                    case 3:
                        DVD dvd = new DVD();
                        itemList.Add(dvd);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Item has been successfully added");
        }
        // Method to search by id ---- also used to in removing...
        public int SearchById(string Id)
        {
            Console.WriteLine("Item could not be found...");
            return -1;
        }
        //Method to remove item by ID
        public void RemoveItem(string Id)
        {
            if (SearchById(Id) != -1)
            {
                itemList.RemoveAt(SearchById(Id));
            }else
            {
                Console.WriteLine("No changes made...");
            }
        }
        //Display method to be called by the Main method
        public void DisplayAll()
        {
            foreach (var item in itemList)
            {
                item.DisplayDetails();
            }
        }
    }
}
