using System;

namespace cSharp_Q2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // 確認・応用問題（クラスを使いこなそう）
            //Q1
            /*
            Console.WriteLine("以下に指定する年月の日数を知りたいです。");

            Console.Write("指定する年：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("指定する月：");
            var month = int.Parse(Console.ReadLine());

            var days = DateTime.DaysInMonth(year, month);
            Console.WriteLine($"{year}年{month}月は{days}日あります。");
            */

            // Q2
            /*
            Console.WriteLine("入力した文字列をDateTime型に変えます。");

            var day1 = DateTime.Parse(Console.ReadLine());
            var day2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"day1は{day1.Year}年{day1.Month}月{day1.Day}日です。");
            Console.WriteLine($"day2は{day2.Year}年{day2.Month}月{day2.Day}日です。");
            */
            
        }
    }
}
