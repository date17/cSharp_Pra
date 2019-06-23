using System;

// 確認・応用問題（ポリモーフィズム）
// 14_Q2

namespace cSharp_14_Q2
{
    // インタフェース
    interface IVirtualPet
    {
        string Name { get;}
        int Mood { get; set; }
        int Energy { get; set; }

        void Eat();
        void Play();
        void Sleep();
        void Rest();


    }
}