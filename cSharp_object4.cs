using System;

namespace csharp_object4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var bmiCalculator = new BmiCalculator();

            var bmikekka = bmiCalculator.GetBmi(176, 67);

            Console.WriteLine("BMIの計算結果は{0:.00}です。",bmikekka);

            var bodyType = bmiCalculator.GetBodyType(bmikekka);
            Console.WriteLine($"あなたの体型は{bodyType}です。");

        }
    }

    class BmiCalculator
    {
        public double GetBmi(double height, double weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);

            return bmi;
        }

        public string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "痩せ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満（1度）";
            }
            else if(bmi < 35)
            {
                type = "肥満（2度）";
            }
            else
            {
                type = "肥満（3度）";
            }
            return type;
                
        }
    }
}
