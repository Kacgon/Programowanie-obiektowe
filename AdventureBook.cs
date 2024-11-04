using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class AdventureBook : Book
    {
        private string adventure;

        public string Adventure
        {
            get { return adventure; }
            set { adventure = value; }
        }

        public AdventureBook(string title, Person author, int datePublication, string adventure) : base(title, author, datePublication)
        {
            this.adventure = adventure;
        }
    }
}
