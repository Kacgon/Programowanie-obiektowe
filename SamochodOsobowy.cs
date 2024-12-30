using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class SamochodOsobowy : Samochod 
    {
        private int Waga;
        private int Pojemnosc;
        private int IloscPasazerow;


        public SamochodOsobowy() : base()
        {
            Console.WriteLine("waga");
            this.Waga =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pojemnosc");
            this.Pojemnosc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ilosc pasazerow");
            this.IloscPasazerow = Convert.ToInt32(Console.ReadLine());
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"{Waga} {IloscPasazerow}");
        }
    }
}
