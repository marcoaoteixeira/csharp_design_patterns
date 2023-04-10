using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;

namespace AbstractFactory.Continents {
    public sealed class AmericanContinentFactory : ContinentFactory {
        public override Carnivore CreateCarnivore() {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore() {
            return new Bison();
        }
    }
}
