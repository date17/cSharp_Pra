using System;

namespace cSharp_8_static
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            var today = DateTime.Today; // 今日の日付を取得する（静的プロパティ）
            Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日");
                */


            // 確認・応用問題（静的メソッド/静的プロパティ/静的クラス）
            // Q1

            var value = new int[] { 55, 60, 45, 70, 85, 93, 68 };
            var total = ArrayUtils.Total(value);
            var average = ArrayUtils.Avarage(value);
            var max = ArrayUtils.Max(value);
            var min = ArrayUtils.Min(value);

            Console.WriteLine($"合計値：{total}\n平均値：{average}\n最大値：{max}\n最小値：{min}");

        }
    }
}
