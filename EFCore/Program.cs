using System;
using EFCore.model;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            insertProduct();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void insertProduct()
        {
            using (var db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Pen Drive";
                db.Add(product);

                product = new Product();
                product.Name = "Memory Card";
                db.Add(product);

                db.SaveChanges();
            }
            return;
        }

        static void updateProduct()
        {
            using (var db = new EFContext())
            {
                Product product = db.Products.Find(1);
                product.Name = "Better Pen Drive";
                db.SaveChanges();
            }
            return;
        }
    }
}
