using System;

// 確認・応用問題（値型と参照型）
// Q2

namespace cSharp_11_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var person = new Person("南舘", "拓弥", Gender.Mile);
            var gen = person.ManOrWoman(person.Gen);


            Console.WriteLine($"{person.FullName}は{gen}です。");
        }
    }
}
