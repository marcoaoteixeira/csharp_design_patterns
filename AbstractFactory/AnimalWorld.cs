namespace AbstractFactory {
    public sealed class AnimalWorld {

        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory) {
            _herbivore = continentFactory.CreateHerbivore();
            _carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain() {
            _carnivore.Eat(_herbivore);
        }
    }
}
