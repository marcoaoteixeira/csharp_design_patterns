// Create and run the African animal world
using AbstractFactory;
using AbstractFactory.Continents;

ContinentFactory continentFactory;
AnimalWorld animalWorld;

// Create and run the African animal world
continentFactory = new AfricanContinentFactory();
animalWorld = new AnimalWorld(continentFactory);
animalWorld.RunFoodChain();

// Create and run the American animal world
continentFactory = new AmericanContinentFactory();
animalWorld = new AnimalWorld(continentFactory);
animalWorld.RunFoodChain();

// Wait for user input
Console.ReadKey();