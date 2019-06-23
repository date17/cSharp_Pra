using System;

namespace cSharp_13_Q1
{
     class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + LastName; }
        }

        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public void Print()
        {
            Console.WriteLine($"名前：{FullName} メールアドレス：{Email} 誕生日：{BirthDay}");
        }
      
    }
}
