using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProductContext())
            {
                //    var firstProvider = new Provider
                //    {
                //        Name = "Яшкино"
                //    };

                //    var secondProvider = new Provider
                //    {
                //        Name = "Рахат"
                //    };

                //    var firstProduct = new Products
                //    {
                //        Name = "Вафли",
                //        Price = 200,
                //        Count = 50,
                //        Provider = firstProvider
                //    };

                //    var secondProduct = new Products
                //    {
                //        Name = "Конфеты",
                //        Price = 150,
                //        Count = 30,
                //        Provider = secondProvider
                //    };

                //    context.Providers.Add(firstProvider);
                //    context.Providers.Add(secondProvider);

                //    context.Products.Add(firstProduct);
                //    context.Products.Add(secondProduct);

                //    context.SaveChanges();


                Console.WriteLine("1 - Добавить новый товар");
                Console.WriteLine("2 - Удалить товар");
                Console.WriteLine("3 - Изменить товар");
                int selectNumber = int.Parse(Console.ReadLine());
                if (selectNumber == 1)
                {
                    AddNewProduct addNewProduct = new AddNewProduct();
                }
                else if (selectNumber == 2)
                {
                    DeleteProduct deleteProduct = new DeleteProduct();
                }
                else if (selectNumber == 3)
                {
                    ChangeProduct changeProduct = new ChangeProduct();
                }

            }
        }
    }
}
