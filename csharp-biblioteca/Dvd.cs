using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : LibraryItem
    {
        private TimeSpan _runningTime;

        private TimeSpan RunningTime {get => this._runningTime; set => this._runningTime = value;}

        public Dvd(string idCode, string title, int publicationYear, string genre, string libraryShelf, string author, TimeSpan runningTime) :base(idCode, title, publicationYear, genre, libraryShelf,author){
            this._runningTime = runningTime;
        }
    }
}
