using Laboratorium_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class Book
    {
        protected string title { get; set; }

        protected Person author { get; set; }
        protected int datePublication;

        public Book(string title, Person author, int datePublication)
        {
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
        }

        public void View()
        {
            Console.WriteLine($"Tytul: \t{title}\nAutor: \t");
            author.View();
            Console.WriteLine($" data wydania : \t {datePublication}");
        }
    }
}
