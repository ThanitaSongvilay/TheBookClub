namespace DesignPatterns.Creators;

public class CatCreator: AnimalCreator
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}