using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    public class Products
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }


        public virtual Provider Provider  { get; set; }
    }
}


