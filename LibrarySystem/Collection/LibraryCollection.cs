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
        public void RemoveItem(LibraryItem item)
        {
            itemList.Remove(item);
        }

        public LibraryItem FindItemByID (string ID)
        {
           return itemList.FirstOrDefault(item => item.ID1 == ID);
        }

        public void DisplayItems()
        {
            foreach (var item in itemList)
            {
                Console.WriteLine($"Title: {item.Title}, ID: {item.ID1}, Year Published: {item.YearPublished}");
            }
        }

        public void DisplayItems(LibraryItem type)
        {
            foreach (LibraryItem item in itemList)
            {

            }
                
        }

        public static void ItemMenu()
        {

        }
    }
}
