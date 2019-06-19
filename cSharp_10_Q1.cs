using System;

namespace cSharp_10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sale = new Sale();
            sale.ProductName = "あ";
            sale.UnitPrice = 100;
            sale.Quantity = 10;
            

            var productName = sale.ProductName;
            var unitPrice = sale.UnitPrice;
            var quantity = sale.Quantity;
         

            Console.WriteLine($"{productName}\n{unitPrice}\n{quantity}");
        }
    }


    class Sale
    {
        
        string pproductName;
        int uunitPrice;
        int qquantity;

        public string ProductName
        {
            get
            {
                return pproductName;
            }

            set
            {
                pproductName = value;
            }
        }
        public int UnitPrice
        {
            get
            {
                return uunitPrice;
            }

            set
            {
                uunitPrice = value;
            }
        }
        
        public int Quantity
        {
            get
            {
               return qquantity;
            }

            set
            {
                qquantity = value;
            }
        }


        /*
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        */
    }
}

