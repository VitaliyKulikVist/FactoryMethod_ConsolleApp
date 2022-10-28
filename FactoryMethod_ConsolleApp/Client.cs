using System;

namespace FactoryMethod_ConsolleApp
{
    class Client
    {
        public void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Додаток: запущено з ConcreteCreator1.");
            Console.ResetColor();
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Додаток: запущено з ConcreteCreator2.");
            Console.ResetColor();
            ClientCode(new ConcreteCreator2());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Додаток: запущено з ConcreteCreator3.");
            Console.ResetColor();
            ClientCode(new ConcreteCreator3());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Додаток: запущено з ConcreteCreator4.");
            Console.ResetColor();
            ClientCode(new ConcreteCreator4());

            Console.ReadKey();
        }
        private void ClientCode(Creator creator)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Клiєнт: Менi невiдомий клас творця," +
                "але це все ще працює.");
            Console.ResetColor();
            Console.WriteLine(creator.SomeOperation());
            
        }
    }
}
