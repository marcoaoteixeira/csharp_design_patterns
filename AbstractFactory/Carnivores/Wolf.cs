namespace AbstractFactory.Carnivores {
    public sealed class Wolf : Carnivore {
        public override void Eat(Herbivore herbivore) {
            Console.WriteLine(GetType().Name +
              " eats " + herbivore.GetType().Name);
        }
    }
}
