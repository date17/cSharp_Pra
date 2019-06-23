using System;

// 確認・応用問題（ポリモーフィズム）
// 14_Q3

namespace cSharp_14_Q3
{
    public class Person
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
