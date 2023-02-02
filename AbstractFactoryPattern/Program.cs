// See https://aka.ms/new-console-template for more information

AbstractFactory factory1 = new ConcreteFactory1();
ProdctA prodctA1=factory1.GetProductTypeA();
ProdctB productB1 = factory1.GetProductTypeB();
prodctA1.GetProductTypeA();
productB1.GetProductTypeB();

AbstractFactory factory2 = new ConcreteFactory2();
ProdctA prodctA2 = factory2.GetProductTypeA();
ProdctB productB2 = factory2.GetProductTypeB();
prodctA2.GetProductTypeA();
productB2.GetProductTypeB();

abstract class ProdctA
{
    public abstract void GetProductTypeA();
}

abstract class ProdctB
{
    public abstract void GetProductTypeB();
}

class ConcreateProductA1 : ProdctA
{
    public override void GetProductTypeA()
    {
        Console.WriteLine("Concrete Product A1");
    }
}

class ConcreateProductA2 : ProdctA
{
    public override void GetProductTypeA()
    {
        Console.WriteLine("Concrete Product A2");
    }
}

class ConcreateProductB1 : ProdctB
{
    public override void GetProductTypeB()
    {
        Console.WriteLine("Concrete Product B1");
    }
}
class ConcreateProductB2 : ProdctB
{
    public override void GetProductTypeB()
    {
        Console.WriteLine("Concrete Product B2");
    }
}

abstract class AbstractFactory
{
    public abstract ProdctA GetProductTypeA();
    public abstract ProdctB GetProductTypeB();
}

class ConcreteFactory1 : AbstractFactory
{
    public override ProdctA GetProductTypeA()
    {
        return new ConcreateProductA1 ();
    }

    public override ProdctB GetProductTypeB()
    {
        return new ConcreateProductB1();
    }
}

class ConcreteFactory2 : AbstractFactory
{
    public override ProdctA GetProductTypeA()
    {
        return new ConcreateProductA2();
    }

    public override ProdctB GetProductTypeB()
    {
        return new ConcreateProductB2();
    }
}