using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.SimpleFactory
{
    internal class Square : iShape
    {
        private double side;

        public Square(double x)
        {
            this.side = x;
        }
        public double CalcArea()
        {
            return side * side; 
        }

        public void Print()
        {
            Console.WriteLine($"Area Of Square:  {CalcArea()}");
        }
    }
}
