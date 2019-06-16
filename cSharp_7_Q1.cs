using System;


// 確認・応用問題（クラス/オブジェクト指向プログラミングの基礎）
// Q1
namespace cSharp_7_Q1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var book = new Book()
            {
                Title = "我輩は猫である",
                Author = "夏目漱石",
                Pages = 620,
                Rating = 4,
                Memo = "私の1番好きな本"
            };

            book.Print();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public string Memo { get; set; }

        public void Print()
        {
            Console.WriteLine($"■タイトル：{Title}");
            Console.WriteLine($"■著者：{Author}");
            Console.WriteLine($"■ページ数：{Pages}\n■ランキング：{Rating}\n■メモ：{Memo}");
        }
    }
}
