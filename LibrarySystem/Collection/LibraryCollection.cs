using LibrarySystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;

namespace LibrarySystem.Collection
{
    internal class LibraryCollection
    {
        private List<LibraryItem> itemList;

        public LibraryCollection() {
        
            itemList = new List<LibraryItem>();
        }

        public void AddItem(LibraryItem item)
        {

            itemList.Add(item);
        }
        //removing an Item from the list
        public void RemoveItem(LibraryItem item)
        {
            itemList.Remove(item);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Item has been successfully removed");
        }
        //Search by ID method:
        public LibraryItem FindById(string ID)
        {
            foreach (LibraryItem item in itemList) 
            {
                if (item.ID1 == ID)
                {
                    return item;
                }

            }
            return null;
        }
        //Display method that uses the object to compensate for thenrest of the details
        public void DisplayItems()
        {
            foreach (var item in itemList)
            {
                Console.WriteLine($"Title: {item.Title} \nID: {item.ID1} \nYear Published: {item.YearPublished}");
                item.DisplayDetails();
            }
        }
    }
}
