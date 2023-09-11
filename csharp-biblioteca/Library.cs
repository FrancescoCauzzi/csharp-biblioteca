using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        // private fields
        private List<LibraryItem> _libraryItems;        
        private List<User> _users;

        private List<ItemLoan> _itemLoans;

        // Public properties
        public List<LibraryItem> LibraryItems {get => _libraryItems; set => _libraryItems = value;}
        
        public List<User> Users { get => _users; set => _users = value; }

        public List<ItemLoan> ItemLoans { get => _itemLoans; set => _itemLoans = value; }

        // Constructor
        public Library()
        {
            _libraryItems = new List<LibraryItem>();            
            _users = new List<User>();
            _itemLoans = new List<ItemLoan>();
        }

               
    }
}
