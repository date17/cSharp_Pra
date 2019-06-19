using System;
using System.Text;

namespace cSharp_10_Q3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var hikaku1 = 0;
            var hikaku2 = 0;
            var pet = new VirtualPet("choko");
            var mood1 = pet.Mood;

            Console.WriteLine($"Petの名前 : {pet.Name}\nPetの機嫌 : {pet.Mood}\nPetの元気度 : {pet.Energy}");

            while (hikaku2 == 0)
            {
                Console.WriteLine("ペットに好きが嫌いかを言ってみてください");
                var mood = Console.ReadLine();
                while (hikaku1 == 0)
                {
                    if (mood != "好き" && mood != "嫌い")
                    {
                        Console.WriteLine("入力に誤りがあります。\n正しい文字を入力してください。");
                        mood = Console.ReadLine();
                    }
                    else
                    {
                        hikaku1 = 1;
                    }
                }
                if (mood == "好き")
                {
                    mood1++;
                    mood1 = pet.MoodUp(mood1);
                    Console.WriteLine($"{pet.Name}の機嫌は{mood1}です。");
                }
                if (mood == "嫌い")
                {
                    mood1--;
                    mood1 = pet.MoodDown(mood1);
                    Console.WriteLine($"{pet.Name}の機嫌は{mood1}です。");
                }

                Console.WriteLine("もう一度ペットに声をかけますか？\nYES : 0   NO : 1");
                hikaku2 = int.Parse(Console.ReadLine());
                while(hikaku2 != 0 && hikaku2 != 1)
                {
                    Console.WriteLine("入力に誤りがあります。再度入力してください。");
                    hikaku2 = int.Parse(Console.ReadLine());
                }
            }
        }
    }

    class VirtualPet
    {
       // ペットの名前
       public string Name { get; set; }
       // ペットの機嫌を示す
       public int Mood { get;}
       // ペットの元気度を示す（エネルギーの値で元気かどうかを判断）
       public int Energy { get; set; }

        
       //コンストラクターの定義
       public VirtualPet(string name)
        {
            Name = name;
            Mood = 0;
            Energy = 100;
        }

        // MoodUpメソッド
        public int MoodUp(int mood)
        {
            if(mood > 10)
            {
                Console.WriteLine("これ以上は上がりません");
                mood = 10;
            }
            return mood;
        }

        // MoodDownメソッド
        public int MoodDown(int mood)
        {
            if (mood < 1)
            {
                Console.WriteLine("これ以上は下がりません");
                mood = 1;
            }
            return mood;
        }
    }
}
