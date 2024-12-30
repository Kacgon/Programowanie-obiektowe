using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class DocumentaryBook : Book
    {
        private string documentary;

        public string Documentary
        {
            get { return documentary; }
            set { documentary = value; }
        }

        public override void View()
        {
            Console.WriteLine(documentary);
        }
        public DocumentaryBook(string title, Person author, int datePublication, string documentary) : base(title, author, datePublication)
        {
            this.documentary = documentary;
        }
    }
}
