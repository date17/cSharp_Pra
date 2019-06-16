using System;


namespace cSharp_9_Q1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 確認・応用問題（クラスを使いこなそう）
            // Q1

            /*
            Console.WriteLine("小数点付きの数値を二つ入力してください");
            Console.Write("数値1：");
            var value1 = double.Parse(Console.ReadLine());
            Console.Write("数値2：");
            var value2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"数値の小さかった方は{Math.Min(value1, value2)}です。");
            */

            /*
            int kurikaesi = 0;
            do
            {
                Console.WriteLine("少数点付きの数値を二つ入力してください");
                Console.Write("数値1：");
                var line1 = Console.ReadLine();

                Console.Write("数値2：");
                var line2 = Console.ReadLine();

                if (line1 == "" || line2 == "")
                {
                    Console.WriteLine("空の行が入力されたので処理を終了します。");
                    break;
                }

                var value1 = double.Parse(line1);
                var value2 = double.Parse(line2);

                // 小数点以下を切り捨て
                var f1 = Math.Floor(value1);
                var f2 = Math.Floor(value2);

                // 小数点以下を切り上げ
                var c1 = Math.Ceiling(value1);
                var c2 = Math.Ceiling(value2);

                Console.WriteLine($"小数点以下を切り捨てした結果\n数値1:{f1}\n数値2:{f2}\n\n");
                Console.WriteLine($"小数点以下を切り上げした結果\n数値1:{c1}\n数値2:{c2}\n\n");

            } while (kurikaesi == 0);
            */
        }   
    }
}
