using FactoryMethod.domain.Entities;
using FactoryMethod.domain.Factory;
using FactoryMethod.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.domain.ConcreteCreator
{
    public class ConcreteCreator2 : Fabrica
    {
        public override IProduct FactoryMethod()
        {
            return new Product2();
        }
    }
}
