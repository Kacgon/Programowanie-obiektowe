using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    public class BankAccount
    {
        private string person;
        private int funds;

        public string Person
        {
            get { return person; }
            set { person = value; }
        }

        public int Funds
        {
            get { return funds; }
            set { funds = value; }
        }

        public BankAccount(string person, int funds)
        {
            this.person = person;
            this.funds = funds;
        }

        public void Wplata()
        {
            Console.WriteLine("Ile chcesz wplacic");
            int wplata = Convert.ToInt32(Console.ReadLine());

            funds = funds + wplata;
            Console.WriteLine(funds);
        }

        public void Wyplata()
        {
            Console.WriteLine("Ile chcesz wyplacic");
            int wyplata = Convert.ToInt32(Console.ReadLine());

            if(wyplata > funds)
            {
                Console.WriteLine("niewystarczające środki");
            }
            else
            {
                funds = funds-wyplata;
                Console.WriteLine(funds);
            }
        }
    }
}
