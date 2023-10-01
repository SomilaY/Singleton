using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.SimpleFactory
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter (R-Rectangle, S-Square,C-Circle): ");
            String opt = Console.ReadLine();

            ShapeFactory factory = new ShapeFactory();
            iShape shape = factory.GetShape(opt);   
            shape.Print();


         
        }
    }
}
