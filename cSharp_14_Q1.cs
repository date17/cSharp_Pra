using System;
using System.Collections.Generic;

// 確認・応用問題（ポリモーフィズム）
// Q1

namespace cSharp_14_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var eatPet = new FoodiePet("a");
            var cheerPet = new CheerfulPet("b");
            var sleepPet = new SleepPet("c");
            var pet = new List<VirtualPet>();
            pet.Add(eatPet);
            pet.Add(cheerPet);
            pet.Add(sleepPet);

            foreach(var pets in pet)
            {
                pets.Eat();
                pets.Play();
                Console.WriteLine("EatメソッドとPlayメソッドを実行しました");
                Console.WriteLine($"名前：{pets.Name}\n機嫌：{pets.Mood}\nエネルギー：{pets.Energy}");
            }
        }
    }
}
