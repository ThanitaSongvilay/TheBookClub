namespace DesignPatterns.Creators;

public abstract class AnimalCreator
{
    public abstract IAnimal CreateAnimal();

    public string SomeOperation()
    {
        var test = CreateAnimal();
        return test.Eat() + test.Sleep();
    }
}