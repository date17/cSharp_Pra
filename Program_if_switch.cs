using System;

namespace cSharp_if_switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 
            int ok = 0;
            var kibou = "のご希望ですね";

            while(ok == 0) { 
          
                Console.WriteLine("ご希望の時間帯の番号を選択してください");
                Console.WriteLine("1:10時から12時");
                Console.WriteLine("2:13時から15時");
                Console.WriteLine("3:16時から18時");

                var value = int.Parse(Console.ReadLine());


                switch (value)
                {
                    case 1:
                        Console.WriteLine($"10時から12時{kibou}");
                        ok = 1;
                        break;

                    case 2:
                        Console.WriteLine($"13時から15時{kibou}");
                        ok = 1;
                        break;

                    case 3:
                        Console.WriteLine($"16時から18時{kibou}");
                        ok = 1;
                        break;

                    default:
                        Console.WriteLine("入力した値に誤りがあります\nもう一度選択してください/n");
                        break;
                        }
                        }

    */

            // 確認応用問題

            // Q1
            /*
            var moji = Console.ReadLine();

            if(moji == "")
            {
                Console.WriteLine("空文字です");
            }
            */



            // Q2
            /*
            var line = Console.ReadLine();
            var value = double.Parse(line);

            if(value < 0)
            {
                Console.WriteLine("valueは負数です");
            }
            else if(value > 0)
            {
                Console.WriteLine("valueは正数です");
            }
            else
            {
                Console.WriteLine("valueは0です");
            }
            */


            // Q4

            /*
            var ren = 0;

            while (ren == 0)
            {
                var word = Console.ReadLine();
                switch (word)
                {
                    case "API":
                        Console.WriteLine("Application Programming Interface");
                        break;

                    case "RDB":
                        Console.WriteLine("Relational Database");
                        break;

                    case "UI":
                        Console.WriteLine("User Interface");
                        break;

                    case "IDE":
                        Console.WriteLine("integrated Development Environment");
                        break;

                    case "HTML":
                        Console.WriteLine("Hyper Text Markup Language");
                        break;

                    case "":
                        Console.WriteLine("文字が入力されていません");
                        break;

                    default:
                        Console.WriteLine("ヒットしませんでした");
                        break;
                }

                Console.WriteLine("再度繰り返しますか？\nyes = 0\nno=1\n");
                ren = int.Parse(Console.ReadLine());

            }

            */

            // Q5
            /*
            int a = 0;
            Console.WriteLine("数値を入力してください\n");
            while(a == 0)
                {
                var kazu = int.Parse(Console.ReadLine());

               if(0 <= kazu && kazu <= 30)
                {
                    Console.WriteLine("不可");
                    a++;
                }
               else if(31 <= kazu && kazu <= 60)
                {
                    Console.WriteLine("可");
                    a++;
                }
               else if(61 <= kazu && kazu <= 80)
                {
                    Console.WriteLine("良");
                    a++;
                }
               else if(81 <= kazu && kazu <= 100)
                {
                    Console.WriteLine("優");
                    a++;
                }
                else
                {
                    Console.WriteLine("入力した数値に誤りがあります\nもう一度数値を入力してくださいn");
                }
            }
            */


                }
            }
        }
    

