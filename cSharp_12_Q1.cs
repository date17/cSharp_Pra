using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharp_12_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<DateTime>();

            list.Add(DateTime.Now);
            list.Add(new DateTime(2019,12,02,15,20,02));
            list.Add(DateTime.Today);

            foreach(var i in list)
            {
                Console.WriteLine(i.ToString("yyyy年MM月dd日 HH:mm"));
            }

            Console.WriteLine($"{list.Count}");
        }
    }
}
