namespace FactoryMethod_ConsolleApp
{
    class ConcreteCreator3 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct3();
        }
    }
}
