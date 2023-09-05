using System;

namespace SRP
{
    public class Book
    {
        // los siguientes atributos cumplen con el principio de SRP ya que son responsabilidades basicas de la clase Book
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        

        // Estas propiedades podrían considerarse una responsabilidad separada y no cumple con el principio de responsabilidad unica ya que la clase 
        // ubica el libro en una biblioteca.
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        // EL siguiente constructor para inicializar un libro nuevo cumple con SRP ya que solo inicializa propiedades
        // que son responsabilidades de la "Book" clase.
        
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }


        // El siguiente metodo no cumple ya que es una resposabilidad esparada y deberia ser manejada por una clase distinta
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}

