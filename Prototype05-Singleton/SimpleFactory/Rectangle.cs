using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.SimpleFactory
{
    internal class Rectangle : iShape
    {
        private double length, width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double CalcArea()
        {
            return length * width;  
        }

        public void Print()
        {
            Console.WriteLine($"Area Of Rectangle:  {CalcArea()}");
            Console.ReadLine();
        }
    }
}
