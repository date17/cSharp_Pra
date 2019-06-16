using System;

namespace cSharp_object
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            var book = new Book(); // Bookクラスのインスタンスを生成

            // bookオブジェクトのプロパティに代入している
            book.Title = "我輩は猫である";
            book.Author = "夏目漱石";
            book.Pages = 610;
            book.Rating = 4;

            var title = book.Title;  // bookオブジェクトのTitleを取り出している
            var author = book.Author;// bookオブジェクトのAuthorを取り出している
            var pages = book.Pages;     // bookオブジェクトのPagesを取り出している
            var rating = book.Rating;   // bookオブジェクトのRatingを取り出している

            /*
            Console.WriteLine($"書籍名：{title}");
            Console.WriteLine($"著者名：{author}");
            Console.WriteLine($"ページ数：{pages}");
            Console.WriteLine($"評価：{rating}");
            */
            Console.WriteLine("メソッドを呼び出します");
            book.Print();
            Console.WriteLine("メソッドを呼び出しました");

        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public void Print()
        {
            Console.WriteLine($"■{Title}");
            Console.WriteLine($" {Author}  {Pages}ページ  評価：{Rating}");
        }
    }
}
