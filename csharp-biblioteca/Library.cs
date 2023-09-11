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

        // Methods
        
        // Add Methods
        // Add Library Item
        public void AddLibraryItem( LibraryItem libraryItem)
        {
            LibraryItems.Add(libraryItem);        
        }

        // Add User

        public void AddUser(User user)
        {
            Users.Add(user);        
        }

        public void AddLoan(LibraryItem libraryItem, User user)
        {
            ItemLoan itemLoan = new ItemLoan(libraryItem, user);
            ItemLoans.Add(itemLoan);
        }

        // find Methods
        

        public void GetItemFromTitle(string title)
        {
            LibraryItem? foundItem = LibraryItems.Find(item => item.Title == title);

            if (foundItem != null)
            {
                Console.WriteLine($"Found: {foundItem.Title}");
            }
            else
            {
                Console.WriteLine("We did not find the item");
            }
        }


        public void GetItemFromCode( string code)
        {
            LibraryItem? libraryItem = LibraryItems.Find(libraryItem => libraryItem.IdCode == code);
            Console.WriteLine(libraryItem?.Title);              
        }

        public void GetLoanFromUserNameAndSurname( string userNameAndSurname){
            ItemLoan? loanedItem = ItemLoans.Find(loanedItem => loanedItem.UserInfo == userNameAndSurname);
            Console.WriteLine(loanedItem?.LibraryItem.Title);  
            
        }

        // Print Library Items
        public void PrintLibraryItems()
        {
            Console.WriteLine("List of Library Items:");
            foreach (LibraryItem item in _libraryItems)
            {
                string mediaType = "";
                if(item is Book){
                    mediaType = "Book";
                }else{
                    mediaType = "Dvd";
                
                }
                Console.WriteLine($"- {item.Title}, media type: {mediaType}");
            }
        }


        
           

               
    }
}
