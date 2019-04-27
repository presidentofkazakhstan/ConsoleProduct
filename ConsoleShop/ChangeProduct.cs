using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    public class ChangeProduct
    {
        public ChangeProduct()
        {
            using (var context = new ProductContext())
            {
                Console.Write("Введите название изменяемого товара: ");
                var nameProduct = Console.ReadLine();

                Console.Write("Введите новое название товара: ");
                string nameNewProduct = Console.ReadLine();

                Console.Write("Введите новое количество товара: ");
                int countNewProduct = int.Parse(Console.ReadLine());

                Console.Write("Введите новую цену товара: ");
                int priceNewProduct = int.Parse(Console.ReadLine());

                var results = context.Products.ToList().Where(x => x.Name == nameProduct);
                foreach (var product in results)
                {
                    product.Name = nameNewProduct;
                    product.Count = countNewProduct;
                    product.Price = priceNewProduct;
                }

                context.SaveChanges();
            }
        }
    }
}
