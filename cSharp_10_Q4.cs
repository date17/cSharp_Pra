using System;

namespace cSharp_10_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("書籍名：");
            var title = Console.ReadLine();
            Console.Write("著者名：");
            var author = Console.ReadLine();
            var book = new Book(title, author);

            book.Print();
           
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Pages = 500;
            Rating = 3;
        }

        public void Print()
        {
            Console.WriteLine($"■書籍名：{Title}\n■著者名：{Author}\n■ページ数：{Pages}\n■ランキング：{Rating}");
        }

    }
}
