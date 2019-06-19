using System;
using System.Text;
namespace cSharp_10_Q2
{
    class MainClass
    {

        // 確認・応用問題（クラスについて掘り下げる）
        // Q2

        public static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            var hikaku = 0;
            var positive = 0;
            var value = new int[]
            {
                10,20,3,-1,4,5
            };

            Console.WriteLine("配列の中の最小値を求めます。\n整数の最小値を求めたい時 : 0\n配列の全ての整数で最小値を求めたい時 : -1 を入力してください。");
            do
            {
                hikaku = 0;
                positive = int.Parse(Console.ReadLine());
                if (positive != 0 && positive != -1)
                {
                    Console.WriteLine("入力に誤りがあります。\n整数の最小値を求めたい時 : 0\n配列の全ての整数で最小値を求めたい時 : -1 を入力してください。");
                    hikaku = 1;
                }

            } while (hikaku == 1);

            if(positive == 0)
            {
                var min = ArrayUtils.GetMin(value);
                Console.WriteLine($"求めた最小値は{min}");
            }
            else
            {
                var min = ArrayUtils.GetMin(value, false);
                Console.WriteLine($"求めた最小値は{min}");
            }
            
        }
    }

    static class ArrayUtils
    {
        public static int Total(int[] numbers)
        {
            var total = 0; 
            foreach(var i in numbers)
            { 
                total += i;
            }

            return total;
        }

        public static int GetMin(int[] numbers, bool isPositive = true)
        {
            if(isPositive == true)
            {
                
                int min = 0;          // 最小値を格納
                int count = 0;
                foreach (var n in numbers)
                {
                    if (n > 0)
                    {
                        min = n;
                        count++;
                        break;
                    }
                }

                if (count == 0)
                {
                    min = 0;
                }
                if (count == 1)
                {
                    foreach (var i in numbers)
                    {
                        if(i > 0 &&  i <= min)
                        {
                            min = i;
                        }
                    }
                }
                return min;
            }
            else
            {
                var min = numbers[0];
                foreach(var j in numbers)
                {
                    if(min >= j)
                    {
                        min = j;
                    }
                }
                return min;
            }

            
        }
    }
}
