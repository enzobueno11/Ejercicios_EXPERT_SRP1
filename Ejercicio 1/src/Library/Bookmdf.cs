using System;

namespace SRP
{
    public class Book1
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book1(string title, string author, string code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}