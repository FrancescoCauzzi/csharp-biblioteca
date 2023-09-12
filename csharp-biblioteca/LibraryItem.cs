using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class LibraryItem
    {
        private string _idCode;
        private string _title;

        private int _publicationYear;

        private string _genre;

        private string _libraryShelf;

        private string _author;

        // Properties
        public string IdCode { get => this._idCode; set => this._idCode = value; }

        public string Title { get => this._title; set => this._title = value; }

        public int PublicationYear { get => this._publicationYear; set => this._publicationYear = value; }

        public string Genre { get => this._genre; set => this._genre = value; }

        public string LibraryShelf { get => this._libraryShelf; set => this._libraryShelf = value; }

        public string Author { get => this._author; set => this._author = value; }

        // Constructor

        public LibraryItem(string idCode, string title, int publicationYear, string genre, string libraryShelf, string author)
        {
            _idCode = idCode;
            _title = title;
            _publicationYear = publicationYear;
            _genre = genre;
            _libraryShelf = libraryShelf;
            _author = author;
        }

        public override string ToString()
        {
            return $@"The item:            
        IdCode: {this._idCode}
        Title: {this._title}
        Publication Year: {this._publicationYear}
        Library Shelf: {this._libraryShelf}
        Genre: {this._genre}
        Author: {this._author}";

        }

    }
}
