using System;

namespace ConsoleApp1
{
    class Product
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public double ShelfLife { get; set; }

        public override string ToString()
        {
            return Title + " " + Quantity + " " + Price + " " + ShelfLife;
        }

        public Product(string productTitle, int productQuantity, 
                       int productPrice, double productShelfLife)
        {
            Title = productTitle;
            Quantity = productQuantity;
            Price = productPrice;
            ShelfLife = productShelfLife;
        }
    }
}
