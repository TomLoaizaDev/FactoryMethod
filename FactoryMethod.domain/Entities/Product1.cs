using FactoryMethod.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.domain.Entities
{
    internal class Product1 : IProduct
    {
        public string Operation()
        {
            return "Product1";
        }
    }
}
