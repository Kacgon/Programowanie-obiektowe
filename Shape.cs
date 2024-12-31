using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    public class Ksztalt
    {
        double y;
        double x;
        double width;
        double height;

        public Ksztalt(double y, double x, double width, double height)
        {
            this.y = y;
            this.x = x;
            this.width = width;
            this.height = height;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figura");
        }
    }

}
