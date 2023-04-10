using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;

namespace AbstractFactory.Continents {
    public sealed class AfricanContinentFactory : ContinentFactory {
        public override Carnivore CreateCarnivore() {
            return new Lion();
        }

        public override Herbivore CreateHerbivore() {
            return new Wildebeest();
        }
    }
}
