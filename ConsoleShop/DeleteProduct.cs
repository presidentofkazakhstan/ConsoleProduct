using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    public class DeleteProduct
    {
        public DeleteProduct()
        {
            using (var context = new ProductContext())
            {
                Console.Write("Введите название удаляемого товара: ");
                var nameProduct = Console.ReadLine();

                var results = context.Products.ToList().Where(x => x.Name == nameProduct);
                foreach(var product in results)
                {
                    context.Products.Remove(product);
                }

                context.SaveChanges();
            }
        }
    }
}
