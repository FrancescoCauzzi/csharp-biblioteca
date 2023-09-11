using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class ItemLoan
    {
        // private fields
        private LibraryItem _libraryItem;

        private string _userInfo;

        private DateTime _checkOutDate;

        private DateTime _dueDate;

        

        // Public Properties

        public LibraryItem LibraryItem{ get => _libraryItem; set => _libraryItem = value;          
        }

        public string UserInfo{ get => _userInfo; set => _userInfo = value;}

        public DateTime CheckOutDate{ get => _checkOutDate; set => _checkOutDate = value;}

        public DateTime DueDate{ get => _dueDate; set => _dueDate = value;}

        // Constructor
        public ItemLoan(LibraryItem libraryItem, User user)
        {
            _libraryItem = libraryItem;

            _userInfo = $"{user.Name} {user.Surname}";
            // down here I set the current date as the check out date
            
            DateTime currentDate = DateTime.Today;
            _checkOutDate = currentDate;
            // the due date is 30 days from the check out date
            _dueDate = _checkOutDate.AddDays(30);
        }      
    }
}
