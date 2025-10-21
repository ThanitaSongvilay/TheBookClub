using DesignPatterns.Creators;

namespace DesignPatterns;

public class DogCreator: AnimalCreator
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}