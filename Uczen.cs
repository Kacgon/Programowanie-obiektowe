using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    class Uczen : Osoba
    {
        string szkola;
        public Uczen(string imie, string nazwisko, string pesel,string szkola) : base(imie, nazwisko, pesel) 
        {
        this.szkola = szkola;
        }

        public void SetSchool(string szkola)
        {
           this.szkola = szkola;
        }
      

        public void ChangeSchool(string nowaSzkola)
        {
            this.szkola = nowaSzkola;
        }

        public override void CanGoAlone(int age)
        {
            if (age < 12) 
            {
                Console.WriteLine("Nie moze sam");
            }
            Console.WriteLine("Moze sam isc");
        }
    }
}
