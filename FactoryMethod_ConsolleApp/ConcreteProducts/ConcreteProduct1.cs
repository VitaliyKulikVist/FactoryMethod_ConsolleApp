using System;

namespace FactoryMethod_ConsolleApp
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Результат ConcreteProduct1}";
        }
    }
}
