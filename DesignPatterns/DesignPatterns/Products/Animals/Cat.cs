namespace DesignPatterns;

public class Cat: IAnmial
{
    public string SayHello()
    {
        return "Miauu I am Cat";
    }

    public string Eat()
    {
        return "I'll eat the tuna my human feeds me.";
    }
}