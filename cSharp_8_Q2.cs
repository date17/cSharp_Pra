using System;

namespace cSharp_8_Q2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("身長(cm)：");
            var height = double.Parse(Console.ReadLine());
            Console.Write("体重(kg)：");
            var weight = double.Parse(Console.ReadLine());

            var bmi = BmiCalculator.GetBmi(height, weight);
            Console.WriteLine($"BMIは{bmi:.00}の{BmiCalculator.GetBodyType(bmi)}です。");
        }
    }
}
