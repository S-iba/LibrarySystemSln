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
            Console.WriteLine("Item has been successfully added");
        }
        public int SearchById(string Id)
        {
            Console.WriteLine("Item could not be found...");
            return -1;
        }

        public void Remove(string Id)
        {
            if (SearchById(Id) != -1)
            {
                itemList.RemoveAt(SearchById(Id));
            }else
            {
                Console.WriteLine("No changes made...");
            }
            

        }
    }
}
