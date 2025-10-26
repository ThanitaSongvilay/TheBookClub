namespace DesignPatterns.Creators;

// The Creator class declares the factory method that is supposed to return 
// an object of a product class. The Creators subclasses usually provide 
// the implementation of this method.
public abstract class AnimalCreator
{
    protected abstract IAnmial FactoryMethod();
    
    // Despite its name, the Creator's primary
    // responsibility is not creating products. Usually, it contains some
    // core business logic that relies on Product objects, returned by the
    // factory method. Subclasses can indirectly change that business logic
    // by overriding the factory method and returning a different type of
    // product from it.
    public string SomeOperation()
    {
        // Call the factory method to create a Product object.
        var product = FactoryMethod();
        
        // Now, use the product.
        var result =  $"This animal says: {product.SayHello()}, and {product.Eat()}";
        return result;
    }
}