using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharp_12_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Book>();

            list.Add(new Book("人間失格", "太宰治", 212, 5));
            list.Add(new Book("我輩は猫である", "夏目漱石", 610, 4));
            list.Add(new Book("女生徒", "太宰治", 279, 4));
            list.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            list.Add(new Book("伊豆踊子", "川端康生", 201, 3));
            list.Add(new Book("こゝろ", "夏目漱石", 378, 5));

            var query1 = list.Where(x => x.Rating >= 4);

            foreach(var i in query1)
            {
                Console.WriteLine($"{i.Title}  {i.Author}");
            }


            var query2 = list.OrderBy(x => x.Author);

            foreach(var j in query2)
            {
                Console.WriteLine($"{j.Author}  {j.Title} {j.Pages} {j.Rating}");
            }

            var query3 = list.Where(x => x.Pages >= 300)
                             .ToArray();

            foreach(var n in query3)
            {
                Console.WriteLine($"{n.Title} {n.Pages}");
            }


            var query4 = list.OrderByDescending(x => x.Pages).ToArray();
            Console.WriteLine($"{query4[0].Title} {query4[0].Pages}");


            

            
        }
    }
}
