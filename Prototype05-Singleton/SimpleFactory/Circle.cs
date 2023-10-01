using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.SimpleFactory
{
    internal class Circle : iShape
    {
        private double radius;
        public Circle(double r)
        {
          this.radius = r;
        }
        public double CalcArea()
        {
            return Math.PI * Math.Pow(radius, 2);   
        }

        public void Print()
        {
            Console.WriteLine($"Area Of Circle:  {CalcArea()}");
        }
    }
}
