namespace AbstractFactory.Carnivores {
    public sealed class Lion : Carnivore {
        public override void Eat(Herbivore herbivore) {
            Console.WriteLine(GetType().Name +
              " eats " + herbivore.GetType().Name);
        }
    }
}
