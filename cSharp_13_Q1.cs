using System;

namespace cSharp_13_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "拓弥",
                LastName = "南舘",
                Email = "date.com",
                BirthDay = new DateTime(1998,12,02) 
            };

            person.Print();

            var employee = new Employee
            {
                FirstName = "一郎",
                LastName = "田中",
                Email = "itiro.com",
                BirthDay = new DateTime(1999, 1, 1)
            };

            employee.Print();
        }
    }
}
