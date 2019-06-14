using System;

namespace cSharp_for_do_while
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            for (var i = 0; i < 50; i++)
            {
                if (i % 13 != 0)
                {
                    continue;
                }

                Console.WriteLine($"{i}は13で割り切れます");
            }
            */

            // 確認・応用問題
            // Q1
            /*
            int a = 0;

            while (a == 0)
            {
                Console.WriteLine("数値を入力してください");
                var value = int.Parse(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine($"value={value} 負数が入力されたのでプログラムを終了します。");
                    a = 1;
                }
                else
                {
                    Console.WriteLine($"value={value} 正数が入力されたのでもう一度入力してください。");
                }
            }
            */

            // Q2
            /*
            int max = 0; //文字列の長さが最大のものを代入
            String maxmoji; //文字列の長さが最大の値を代入

            Console.Write("文字列1:");
            var moji = Console.ReadLine();
            var len = moji.Length;
            max = len;
            maxmoji = moji;

            for ( int n = 2; n <= 10; n++)
            {
                Console.Write("文字列{0}:", n);
                moji = Console.ReadLine();
                len = moji.Length;

                if(len > max)
                {
                    max = len;
                    maxmoji = moji;
                }
            }
            Console.WriteLine($"1番文字列が長かったのは{maxmoji}です。");
            */

            // Q3
            /*
            int count = 0;
            for(int n = 1; n <= 500; n++)
            {
                if((n % 3 == 0 || n % 7 == 0) && n % 2 == 1)
                {
                    Console.WriteLine($"{n}");
                    count++;
                }
            }

            Console.WriteLine($"条件を満たす数の個数は{count}です。");
            */


            // Q4
            /*
            double sum = 0;
            int ren = 0;
            while (ren == 0)
            {
                Console.WriteLine("値を入力してください");
                var value = double.Parse(Console.ReadLine());

                if(value < 0)
                {
                    break;
                }
                sum += value;
                
                Console.WriteLine("入力を続けますか？\nYes = 0    No = 1");
                ren = int.Parse(Console.ReadLine());
              
                while(ren != 0 && ren != 1)
                {
                    Console.WriteLine("入力に誤りがあります。再度入力してください。\nYes = 0    No = 1");
                    ren = int.Parse(Console.ReadLine());
                }
                

            }
            Console.WriteLine($"入力した値の合計値は{sum}です。");

           */

            //　Q5
            /*
            var roop = 1;

            Console.Write("何段作りますか？");
            var dan = int.Parse(Console.ReadLine());
            Console.WriteLine($"{dan}段作ります");
            var value = "*";
            for(int i = 0; i < dan; i++)
            {
                for (int j = 0; j < roop; j++)
                {
                    Console.Write($"{value}");
                }
                roop++;
                Console.Write("\n");
            }
            */
            
        }
    }
}
