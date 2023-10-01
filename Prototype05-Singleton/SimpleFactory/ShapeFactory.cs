using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.SimpleFactory
{
    internal class ShapeFactory
    {
        public iShape GetShape(string type)
        {
            iShape obj = null;
            if (type.Equals("R"))
            {
                double x, y;
                Console.WriteLine("Enter Length: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Rectangle(x, y);
            }
            else if (type.Equals("S"))
            {
                double s;
                Console.WriteLine("Enter A Side :");
                s = Convert.ToDouble(Console.ReadLine());
                obj = new Square(s);
            }
            else if (type.Equals("C"))
            {
                double r;
                Console.WriteLine("Enter Radius : ");
                r = Convert.ToDouble(Console.ReadLine());   
                obj = new Circle(r);

            }
            return obj;
        }
    }
}
