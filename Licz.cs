using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_2
{
    internal class Licz
    {
        private int value;

        public Licz(int value)
        {
            this.value = value;
        }

        public void Dodaj(int dodana)
        {
            value = value + dodana;
        }
        public void Odejmij(int odejmij) {
        value = value - odejmij;
        }

        public int Value()
        {
            return value;
        }
    }
}
