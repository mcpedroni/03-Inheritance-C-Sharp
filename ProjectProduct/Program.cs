using System;
using System.Collections.Generic;
using System.Globalization;
using ProjectProduct.Entities;

namespace ProjectProduct {
    class Program {

        static void Main(string[] args) {

            List<Product> productList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productList.Add(new ImportedProduct(name, price, customFee));
                } else if (ch == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, date));
                } else {
                    productList.Add(new Product(name, price));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in productList) {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
