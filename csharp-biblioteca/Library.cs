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
        // down here is better to use a dictionary to associate the code with the item
        private Dictionary<string, LibraryItem> _libraryItems;

        // users
        private List<User> _users;

        // items loans

        private List<ItemLoan> _itemLoans;

        // Public properties
        public Dictionary<string, LibraryItem> LibraryItems { get => _libraryItems; set => _libraryItems = value; }

        public List<User> Users { get => _users; set => _users = value; }

        public List<ItemLoan> ItemLoans { get => _itemLoans; set => _itemLoans = value; }

        // Constructor
        public Library()
        {
            _libraryItems = new Dictionary<string, LibraryItem>();
            _users = new List<User>();
            _itemLoans = new List<ItemLoan>();
        }

        // Methods

        // Add Methods
        // Add Library Item
        public void AddLibraryItem(LibraryItem libraryItem)
        {
            LibraryItems.Add(libraryItem.IdCode, libraryItem);
        }

        // Add User

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        // Add loan

        public void AddLoan(LibraryItem libraryItem, User user)
        {
            ItemLoan itemLoan = new ItemLoan(libraryItem, user);
            ItemLoans.Add(itemLoan);
        }

        // find Methods


        public List<LibraryItem> GetItemFromTitle(string title)
        {
            List<LibraryItem> retrievedLibraryItems = new List<LibraryItem>();

            var listLibraryItem = LibraryItems.Values;

            foreach (var item in listLibraryItem)
            {
                if (item.Title == title)
                {
                    retrievedLibraryItems.Add(item);
                }
            }

            return retrievedLibraryItems;

            /*
            LibraryItem? foundItem = LibraryItems.Find(item => item.Title == title);

            if (foundItem != null)
            {
                // Console.WriteLine($"Found: {foundItem.Title}");
                return foundItem.Title;
            }
            else
            {
                string noMatchTitleMessage = $"We did not find the item with the title '{title}'";
                return noMatchTitleMessage;
            }
            */
        }

        public static void PrintListOfLibraryItems(List<LibraryItem> list)
        {
            if (list.Count > 0)
            {


                Console.Write("[ ");

                for (int i = 0; i < list.Count; i++)
                {
                    if (i < list.Count - 1)
                    {
                        Console.Write(list[i] + ", ");
                    }
                    else
                    {
                        Console.Write(list[i]);
                    }
                }

                Console.WriteLine(" ]");
            }
            else
            {
                Console.WriteLine("No items found");
            }

        }


        public LibraryItem GetItemFromCode(string code)
        {
            var findDocCode = LibraryItems[code];
            return findDocCode;
            /*
            LibraryItem? foundItem = LibraryItems.Find(libraryItem => libraryItem.IdCode == code);


            if (foundItem != null)
            {
                // Console.WriteLine($"The item associated to the code {code} is: {foundItem.Title}");
                return foundItem.Title;
            }
            else
            {
                string noMatchCodeMessage = "We did not find the item, your code does not match";
                return noMatchCodeMessage;

            }
            */
        }

        public void PrintLoanFromUserNameAndSurname(string userNameAndSurname)
        {
            List<ItemLoan> loanedItems = ItemLoans.FindAll(loan => loan.UserInfo == userNameAndSurname);

            if (loanedItems.Count > 0)
            {
                Console.WriteLine($"Found {loanedItems.Count} loan(s) for {userNameAndSurname}:");
                foreach (var loan in loanedItems)
                {
                    Console.WriteLine($"- {loan.LibraryItem.Title}, the due date is {loan.DueDate.ToString("dd/MM/yyyy")}");
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
            foreach (LibraryItem item in _libraryItems.Values)
            {
                string mediaType = "";
                if (item is Book)
                {
                    mediaType = "Book";
                }
                else
                {
                    mediaType = "Dvd";

                }
                Console.WriteLine($"- {item.Title}, media type: {mediaType}");
            }
        }






    }
}
