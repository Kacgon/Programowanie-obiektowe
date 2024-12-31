using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    public class Circle : Ksztalt
    {

        public Circle(double x, double y, double width, double height) : base(x, y, width, height) { }
        public override void Draw()
        {
            Console.WriteLine("Probujemy narysowac Circle");
        }

    }
}

