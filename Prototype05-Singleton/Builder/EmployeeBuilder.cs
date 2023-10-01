using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prototype05_Singleton.Builder
{
    internal class EmployeeBuilder
    {
        public string StaffNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public double salary { get; set; }

        public EmployeeBuilder WithStaffNO(string StaffNO)
        {
            this.StaffNO = StaffNO; 
            return this;
        }

        public EmployeeBuilder WithName(string Name, string Surname)
        { this.Name = Name; this.Surname = Surname; return this;}

        public EmployeeBuilder WithCredentials(string username,string password)
        { this.Username = username; this.Password = password; return this;}

        public EmployeeBuilder WithEmail(string email)
        { this.email = email; return this;}

        public EmployeeBuilder WithAge(int age)
        { this.Age = age; return this;}

        public EmployeeBuilder WithSalary(double salary)
        { this.salary = salary; return this;}

        public EmployeeBuilder Build()
        {
             return this;
        }
        public override string ToString()
        {
            return $"Staff NO: {StaffNO}\n" + $"Name: {Name} {Surname}\n" + $"Age: {Age}\n" +$"Salary: {salary}";



        }
    }
}
