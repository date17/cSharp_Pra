using System;

namespace cSharp_object3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sale = new Sale()
            {
                ProductName = "おにぎり",
                UnitPrice = 120,
                Quantity = 4
            };

            sale.GetAmount();
            Console.WriteLine($"合計金額は{sale.GetAmount()}円です。");
        }
    }

    class Sale
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public int GetAmount()
        {
            return UnitPrice * Quantity;
        }
    }
}
