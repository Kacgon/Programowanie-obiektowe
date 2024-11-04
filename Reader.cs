using Laboratorium_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class Reader : Person
    {
        private Book[] przeczytane;

        public Book[] Przeczytane
        {
            get { return przeczytane; }
            set { przeczytane = value; }
        }
        public Reader(string firstName, string lastName, int age, Book[] przeczytane) : base(firstName, lastName, age)
        {
            this.przeczytane = przeczytane;
        }

        public void AddBook(Book nowaKsiazka)
        {
            przeczytane = [.. przeczytane, nowaKsiazka];
            foreach (Book book in przeczytane)
            {
                book.View();
            }

        }
        public void ViewReader()
        {
            Console.WriteLine($"Ksiazki przeczytane przez {FirstName} {LastName}");
            foreach (Book book in przeczytane)
            {
                book.View();
            }
        }
    }
};

