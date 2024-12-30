using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_3
{
    internal class Samochod
    {
        private string Model { get; set; }

        private string Marka { get; set; }
        private string Kolor { get; set; }
        private int RokProdukcji { get; set; }
        private int Przebieg {  get; set; }

        public Samochod()
        {
            Console.WriteLine("model");
            this.Model = Console.ReadLine();

            Console.WriteLine("marka");
            this.Marka = Console.ReadLine(); 

            Console.WriteLine("kolor");
            this.Kolor = Console.ReadLine(); 

            Console.WriteLine("rok prod");
            this.RokProdukcji = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("przebieg");
            this.Przebieg = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void View()
        {
            Console.WriteLine($"Samochod:{Model}{Marka}{Kolor}");
        }
    }
}
