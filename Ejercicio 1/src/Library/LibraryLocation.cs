using System;

namespace SRP
{
        public class LibraryLocation
    {
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }

        public Book Book { get; }

        public LibraryLocation(Book book, string sector, string shelve)
        {
            this.Book = book;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        public void ShelveBook(string sector, string shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}
