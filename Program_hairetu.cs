using System;

namespace cSharp_hairetu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //　確認・応用問題
            // Q1

            /*
            var  value = new int[8];
            int sum = 0;

            for(int i = 0; i < value.Length; i++)
            {
                value[i] = int.Parse(Console.ReadLine());
                sum += value[i];
            }
            Console.WriteLine($"合計は{sum}です。");
            */

            // Q2

            /*
            var value = new int[20];

            for(int i = 0; i < value.Length; i++)
            {
                value[i] += 100 + i;
            }

            Console.WriteLine("配列に格納した整数を表示します。");
            for(int j = 0; j < value.Length; j++)
            {
                Console.WriteLine($"{value[j]}");
            }
            */


            // Q3
            /*
            var str = new string[10];
            var max = 0;
            string maxstr = "";
            for(int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
                if(str[i].Length >= max)
                {
                    max = str[i].Length;
                    maxstr = str[i];
                }
            }
            Console.WriteLine($"最も文字数の多かった値は{maxstr}です。");
            */

            // Q4
            /*
            string[,] str = { { "sum", "日曜日" }, { "mon", "月曜日" }, { "tue", "火曜日" }, { "wed", "水曜日" }, { "thu", "木曜日" }, { "fri", "金曜日" }, { "sat", "土曜日" } };

            for(int i = 0; i < str.GetLength(0); i++)
            {
                Console.WriteLine($"{str[i,1]} ({str[i,0]})");
            }
            */
        }
    }
}
