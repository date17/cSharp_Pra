using System;

// 確認・応用問題（値型と参照型）
// Q3

namespace cSharp_11_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = new Card(CardSuit.Spade, 13);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            ChangeToAce(king);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
        }

        private static void ChangeToAce(Card card)
        {
            card = new Card(CardSuit.Club, 1);
            
        }

    }


    enum CardSuit
    {
        Club,
        Spade,
        Heart,
        Diamond
    }

    class Card
    {
        public CardSuit Suit { get; set; }
        public int Number { get; set; }

        public Card(CardSuit suit, int number)
        {
            Suit = suit;
            Number = number;
        }
    }
}
