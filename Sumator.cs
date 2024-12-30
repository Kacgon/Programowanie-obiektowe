using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    internal class Sumator
    {
        private List<int> Liczby;

        public Sumator(List<int> Liczby)
        {
            this.Liczby = Liczby;
        }
        public void wypiszLiczby()
        {
            foreach (int el in Liczby)
            {
                Console.WriteLine(el);
            }
        }

        public void ileElement()
        {
            Console.WriteLine(Liczby.Count);
        }
        public void Suma()
        {
            int i  = 0;
            foreach(int el in Liczby)
            {
                i = i + el;
            }
            Console.WriteLine(i);
        }

        public void SumaPrzez2()
        {
            int i = 0;
            foreach (int el in Liczby)
            {
                i = i + el;
            }
            Console.WriteLine(i / 2);
        }

         public void lowHigh(List<int> lista, int low, int high)
    {
        Console.WriteLine("liczby w przedziale");
        for (int i = Math.Max(0, low); i <= Math.Min(high, lista.Count - 1); i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
    }
    
}
