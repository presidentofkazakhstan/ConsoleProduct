using System;
using System.Collections.Generic;

namespace ConsoleShop
{
    public class Provider
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public virtual ICollection<Products> Products  { get; set; }
    }
}