using System;

// 確認・応用問題（継承）
// 13_Q1
namespace cSharp_13_Q2
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Book(string title, string author, int pages, int rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

        // ToString()メソッドをオーバーライド
        public override string ToString()
        {
            var s = $"{Title} {Author} {Pages} {Rating}";
            return s;
        }
    }
}
