using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    public static class OsobaExtensions
    {
        public static void WypiszOsoby(this List<IOsoba> osoby)
        {
            foreach (var osoba in osoby)
            {
                Console.WriteLine(osoba.zwrocPelnaNazwe());
            }
        }
    }
}
