namespace ModuleWorkModel
{
    public class Drink
    {
        public readonly Ingredients Composition;

        public Drink(string name, int coffee, int milk, int water)
        {
            Name = name;
            Composition = new Ingredients(coffee, milk, water);
        }

        public string Name { get; }
    }
}