using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : LibraryItem
    {
        private int _pageNumber;

        private int PageNumber {get => this._pageNumber; set => this._pageNumber = value;}

        public Book(string idCode, string title, string publicationYear, string genre, string libraryShelf, string author, int pageNumber) :base(idCode, title, publicationYear, genre, libraryShelf,author){
            this._pageNumber = pageNumber;
        }

    }
}
