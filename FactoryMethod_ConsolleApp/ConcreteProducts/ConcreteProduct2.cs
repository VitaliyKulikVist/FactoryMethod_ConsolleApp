using System;

namespace FactoryMethod_ConsolleApp
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Результат ConcreteProduct1}";
        }
    }
}
