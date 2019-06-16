using System;
using System.IO;

namespace cSharp_9_Q3
{
    class MainClass
    {
        // 確認・応用問題（クラスを使いこなそう）
        // Q3
        public static void Main(string[] args)
        {
            /*
            var lines = new string[]
            {
                "祇園精舎の鐘の声、諸行無常の響あり。",
                "沙羅双樹の花の色、盛者必哀の理をあらはす。",
                "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ"
            };

            File.WriteAllLines(@"/Users/minamidatetakuya/desktop/aaa/祇園精舎.txt", lines);
            */

            var line = File.ReadAllLines(@"/Users/minamidatetakuya/desktop/aaa/祇園精舎.txt");

            foreach (var n in line)
            {
                Console.WriteLine(n);
            }

            /*
            var lineLength = 0;
            foreach(var i in lines)
            {
                lineLength += i.Length;
            }

            Console.WriteLine($"祇園精舎.txtは{lineLength}文字あります。");
            */

            foreach (var i in line)
            {
                var str = i.Split('、');

                foreach (var j in str)
                {
                    Console.WriteLine(j);
                }
               
            }
          
              
        }
    }
}
