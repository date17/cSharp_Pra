using System;

// 確認・応用問題（継承）
// 13_Q1
namespace cSharp_13_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book ("我輩は猫である","夏目漱石",610,5);

            object books = book;
            var str = books.ToString();

            Console.WriteLine(str);
        }
    }
}
