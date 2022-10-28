using System;

namespace FactoryMethod_ConsolleApp
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            // Викличте фабричний метод, щоб створити об’єкт Product.
            var product = FactoryMethod();
            // Тепер використовуйте продукт.
            Console.ForegroundColor = ConsoleColor.Green;
            var result = "Творець: той самий код творця, з яким щойно працював "
                + product.Operation();

            return result;
        }
    }
}
