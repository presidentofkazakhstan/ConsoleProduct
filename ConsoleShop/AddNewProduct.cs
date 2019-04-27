using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    public class AddNewProduct
    {
        public AddNewProduct()
        {
            using (var context = new ProductContext())
            {
                Console.Write("Введите поставщика товара: ");
                var nameProvider = Console.ReadLine();

                var newProvider = new Provider
                {
                    Name = nameProvider
                };

                Console.Write("Введите название товара: ");
                var nameProduct = Console.ReadLine();

                Console.Write("Введите цену товара: ");
                int priceProduct = int.Parse(Console.ReadLine());

                Console.Write("Введите кол-во товара: ");
                int countProduct = int.Parse(Console.ReadLine());

                var newProduct = new Products
                {
                    Name = nameProduct,
                    Price = priceProduct,
                    Count = countProduct,
                    Provider = newProvider

                };

                context.Providers.Add(newProvider);
                context.Products.Add(newProduct);

                context.SaveChanges();

            }
        }
    }
}
