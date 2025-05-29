using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Classes;

namespace LibrarySystem.Classes
{
    internal class LibraryItem
    {
        private string title;
        private string ID;
        private int yearPublished;

        public string Title { get => title; set => title = value; }
        public string ID1 { get => ID; set => ID = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
    }
}
