namespace DesignPatterns.Creators;

public class ConcreteDog: AnimalCreator
{
    protected override IAnmial FactoryMethod()
    {
        return new Dog();
    }
}