using System;
using System.Collections.Generic;

// 確認・応用問題（ポリモーフィズム）
// 14_Q2

namespace cSharp_14_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pet1 = new FoodiePet("フード");
            var pet2 = new CheerfulPet("チャー");
            var pet3 = new SleepPet("スリープ");

            var pets = new List<IVirtualPet>();

            pets.Add(pet1);
            pets.Add(pet2);
            pets.Add(pet3);

            foreach(var p in pets)
            {
                
                p.Rest();
                Console.WriteLine("Eatメソッドを実行しました"); 
                Console.WriteLine("Restメソッドを実行しました");

                Console.WriteLine($"名前：{p.Name}\n機嫌：{p.Mood}\nエネルギー：{p.Energy}");
            }

        }
    }
}
