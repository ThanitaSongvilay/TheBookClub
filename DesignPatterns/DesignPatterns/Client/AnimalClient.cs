using DesignPatterns.Creators;

namespace DesignPatterns.Client;

public class AnimalClient
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the CatCreator.");
        ClientCode(new CatCreator());
            
        Console.WriteLine("");

        Console.WriteLine("App: Launched with the DogCreator.");
        ClientCode(new DogCreator());
    }

    // The client code works with an instance of a concrete creator, albeit
    // through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's
    // subclass.
    public void ClientCode(AnimalCreator creator)
    {
       
        Console.WriteLine(creator.SomeOperation());
    }
}