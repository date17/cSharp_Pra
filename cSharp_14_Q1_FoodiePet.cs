using System;

// 確認・応用問題（ポリモーフィズム）
// Q1

namespace cSharp_14_Q1
{
    // 派生クラス
    class FoodiePet : VirtualPet // 継承
    {
        public FoodiePet(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Mood += 5;
            Energy += 10;
        }

        public override void Play()
        {
            Mood -= 5;
            Energy -= 5;
        }

        public override void Sleep()
        {
            Mood -= 10;
            Energy -= 10;
        }

    }

    // 派生クラス
    class CheerfulPet : VirtualPet // 継承
    {
        public CheerfulPet(string name) : base(name)
        {

        }

        public override void Eat()
        {
            Mood -= 5;
            Energy -= 10;
        }

        public override void Play()
        {
            Mood += 5;
            Energy += 10;
        }

        public override void Sleep()
        {
            Mood -= 10;
            Energy -= 5;
        }

    }

    // 派生クラス
    class SleepPet : VirtualPet // 継承
    {
        public SleepPet(string name) : base(name)
        {

        }

        public override void Eat()
        {
            Mood -= 10;
            Energy -= 5;
        }

        public override void Play()
        {
            Mood -= 5;
            Energy -= 10;
        }

        public override void Sleep()
        {
            Mood += 10;
            Energy += 5;
        }
    }
}
