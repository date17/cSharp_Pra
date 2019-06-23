using System;

// 確認・応用問題（ポリモーフィズム）
// Q1

namespace cSharp_14_Q1
{
    // 基底クラス
    class VirtualPet
    {
        public string Name { get; set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public VirtualPet(string name)
        {
            Name = name;
            Mood = 1;
            Energy = 5;
        }

        public virtual void Eat()
        {

        }

        public virtual void Play()
        {

        }

        public virtual void Sleep()
        {

        }
    }
}
