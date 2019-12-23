namespace ModuleWorkModel
{
    public class Drink
    {
        public readonly IIngredients Composition;

        public Drink(string name, IIngredients composition)
        {
            Name = name;
            Composition = composition;
        }

        public string Name { get; }
    }
}