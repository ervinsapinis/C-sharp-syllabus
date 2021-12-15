using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mouseProduct = new Product("Logitech mouse", 70, 14);
            Product iphoneProduct = new Product("iPhone 5s", 999.99, 3);
            Product printerProduct = new Product("Epson EB-U05", 440.46, 1);

            mouseProduct.PrintProduct();
            iphoneProduct.PrintProduct();
            printerProduct.PrintProduct();

            mouseProduct.ChangeQuantity(16);
            mouseProduct.ChangePrice(69.99);
            mouseProduct.PrintProduct();
        }
    }
}
