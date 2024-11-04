using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class Reviewer : Reader
    {

        public Reviewer(string firstName, string lastName, int age, Book[] przeczytane) : base(firstName, lastName, age, przeczytane)
        {
        }

        public void ViewReviews()
        {
            foreach (var oceniona in Przeczytane)
            {
                var random = new Random();
                var ocena = random.Next(1, 10);
                oceniona.View(); 
                Console.WriteLine($"Oceniono na ocenę {ocena}"); 
            }
        }
    }
}
