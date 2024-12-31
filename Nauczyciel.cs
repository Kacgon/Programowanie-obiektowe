using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    internal class Nauczyciel : Uczen
    {
        string tytulNaukowy;
        List<Uczen> PodwladniUczniowie;
        public Nauczyciel(string imie, string nazwisko, int pesel, string szkola, string tytulNaukowy, List<Uczen> PodwladniUczniowie) : base(imie, nazwisko, pesel,  szkola)
        {
            this.tytulNaukowy = tytulNaukowy;
            this.PodwladniUczniowie = PodwladniUczniowie;
        }

        public void WhichStudentCanGoHomeAlone(List<Uczen> listaUczniow)
        {
            foreach (Uczen uczn in listaUczniow) 
            {
                uczn.CanGoAlone(uczn.getAge(uczn.GetPsl()));
            }

        }
    }
}
    