using System;

// 確認・応用問題（ポリモーフィズム）
// 14_Q3

namespace cSharp_14_Q3
{
    public class Employee : Person
    {
        public int Number { get; set; }

        public DateTime HireDate { get; set; }

    }
}
