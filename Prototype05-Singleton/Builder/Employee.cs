using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.Builder
{
    internal class Employee
    {
        public int StaffNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double salary { get; set; }

        public Employee(int staffNO, string name, string surname, string email, string username, string password, int age, double salary)
        {
           
        }

        public Employee(int staffNO, string name, string surname)
        {
            StaffNO = staffNO;
            Name = name;
            Surname = surname;
        }

        public Employee(int staffNO)
        {
            StaffNO = staffNO;
        }

        public Employee(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
