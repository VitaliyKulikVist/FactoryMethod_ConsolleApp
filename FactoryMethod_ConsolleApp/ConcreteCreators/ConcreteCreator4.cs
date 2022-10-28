namespace FactoryMethod_ConsolleApp
{
    class ConcreteCreator4 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct4();
        }
    }
}
