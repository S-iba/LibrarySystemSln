using LibrarySystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Collection
{
    internal class LibraryCollection
    {
        private List<LibraryItem> itemList = new List<LibraryItem>();

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
            return itemList.FirstOrDefault(ID => item.Title.Equals(ID, StringComparison.OrdinalIgnoreCase));
        }

    public void DisplayItems()
        {
            foreach (var item in itemList)
            {
                Console.WriteLine($"Title: {item.Title}, ID: {item.ID}, Year Published: {item.YearPublished}");
            }
        }
    }
}
