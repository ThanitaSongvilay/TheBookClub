// See https://aka.ms/new-console-template for more information

using DesignPatterns;
using DesignPatterns.Client;
using DesignPatterns.Creators;

Console.WriteLine("Hello, World!");
AnimalClient factoryMethod = new AnimalClient();
AnimalCreator c = new CatCreator();
AnimalCreator d = new DogCreator();

factoryMethod.Main();