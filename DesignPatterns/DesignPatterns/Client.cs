using DesignPatterns.Creators;

namespace DesignPatterns;

public class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteDog.");
        ClientCode(new ConcreteDog());
            
        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCat.");
        ClientCode(new ConcreteCat());
    }

    // The client code works with an instance of a concrete creator, albeit
    // through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's
    // subclass.
    public void ClientCode(AnimalCreator creator)
    {
        // ...
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                          "but it still works.\n" + creator.SomeOperation());
        // ...
    }
}