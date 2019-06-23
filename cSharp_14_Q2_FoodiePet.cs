using System;

// 確認・応用問題（ポリモーフィズム）
// 14_Q2

namespace cSharp_14_Q2
{
    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public FoodiePet(string name)
        {
            Name = name;
            Mood = 1;
            Energy = 5;
        }

        public void Eat()
        {
            Mood += 5;
            Energy += 10;
        }

        public void Play()
        {
            Mood += 0;
            Energy -= 2;
        }

        public void Sleep()
        {
            Mood -= 5;
            Energy -= 5;
        }

        public void Rest()
        {
            Mood += 2;
            Energy += 2;
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 1;
            Energy = 5;
        }

        public void Eat()
        {
            Mood -= 5;
            Energy -= 10;
        }

        public void Play()
        {
            Mood += 10;
            Energy += 5;
        }

        public void Sleep()
        {
            Mood -= 2;
            Energy -= 2;
        }

        public void Rest()
        {
            Mood += 5;
            Energy += 5;
        }
    }

    class SleepPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public SleepPet(string name)
        {
            Name = name;
            Mood = 1;
            Energy = 5;
        }

        public void Eat()
        {
            Mood += 2;
            Energy += 5;
        }

        public void Play()
        {
            Mood -= 10;
            Energy -= 5;
        }

        public void Sleep()
        {
            Mood += 5;
            Energy += 10;
        }

        public void Rest()
        {
            Mood += 5;
            Energy += 5;
        }
    }
}
