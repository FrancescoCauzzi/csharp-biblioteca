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
        

        public string GetItemFromTitle(string title)
        {
            LibraryItem? foundItem = LibraryItems.Find(item => item.Title == title);

            if (foundItem != null)
            {
                // Console.WriteLine($"Found: {foundItem.Title}");
                return foundItem.Title;
            }
            else
            {
                const string noMatchTitleMessage = "We did not find the item";
                return noMatchTitleMessage;
            }
        }


        public string GetItemFromCode( string code)
        {
            LibraryItem? foundItem = LibraryItems.Find(libraryItem => libraryItem.IdCode == code);
            

            if (foundItem != null)
            {
                // Console.WriteLine($"The item associated to the code {code} is: {foundItem.Title}");
                return foundItem.Title;
            }
            else
            {
                const string noMatchCodeMessage = "We did not find the item, your code does not match";
                return noMatchCodeMessage;
                
            }              
        }

        public void PrintLoanFromUserNameAndSurname(string userNameAndSurname)
        {
            List<ItemLoan> loanedItems = ItemLoans.FindAll(loan => loan.UserInfo == userNameAndSurname);

            if (loanedItems.Count > 0)
            {
                Console.WriteLine($"Found {loanedItems.Count} loan(s) for {userNameAndSurname}:");
                foreach (var loan in loanedItems)
                {
                    Console.WriteLine($"- {loan.LibraryItem.Title}");
                }
            }
            else
            {
                Console.WriteLine($"No loans found for {userNameAndSurname}.");
            }
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
