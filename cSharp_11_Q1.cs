using System;

// 確認・応用問題（値型と参照型）
// Q1 （自分が生まれた日が日曜日かどうかを判定するコード）

namespace cSharp_11_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(1998, 12, 2);// 自分の誕生日のインスタンスを生成
            Console.WriteLine($"私の生年月日は{dateTime.Year}年{dateTime.Month}月{dateTime.Day}日です");
            var dayOfWeek = DayOfWeek.Sunday;　// DayOfWeek列挙型のsundayを代入
            var birthdayOfWeek = dateTime.DayOfWeek; // 生成したインスタンスのDayOfWeekのプロパティを代入
            if(dayOfWeek == birthdayOfWeek) // 自分の誕生日が日曜日かどうかの比較
            {
                Console.WriteLine($"私の生まれた日は日曜日です。");
            }
            else
            {
                Console.WriteLine($"私の生まれた日は日曜日ではありません。");
            }



        }
    }
}
