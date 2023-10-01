using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.Builder
{
    internal class EmployeeTester
    {
        static void Main(string[] args)
        {
            EmployeeBuilder eb = new EmployeeBuilder()
                .WithStaffNO("1234").WithName("Somila", "Yanta").WithSalary(100000000).Build();

            Console.WriteLine(eb.ToString());
            Console.ReadLine();
        }
    }
}
