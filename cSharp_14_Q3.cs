using System;

// 確認・応用問題（ポリモーフィズム）
// 14_Q3

namespace cSharp_14_Q3
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
                BirthDay = new DateTime(1998, 12, 02)
            };

            var employee = new Employee
            {
                FirstName = "太郎",
                LastName = "田中",
                Email = "taro.com",
                BirthDay = new DateTime(1990, 01, 01),
                Number = 1,
                HireDate = new DateTime(2019, 10, 10)
            };

            object person1 = person;
            object person2 = employee;

            
            Console.WriteLine(person.ToString());
            Console.WriteLine(employee.ToString());
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
