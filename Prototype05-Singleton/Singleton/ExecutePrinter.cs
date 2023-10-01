using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.Singleton
{
    internal class ExecutePrinter
    {
        static void Main(string[] args)
        {
            Printer p1 = new Printer();
            Printer p2 = new Printer();

            p1.Model = "Konica";

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());    
        }
    }
}
