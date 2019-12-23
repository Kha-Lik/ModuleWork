namespace ModuleWorkModel
{
    public interface IIngredients
    {
        IIngredients Sub(IIngredients b);
        IIngredients Sum(IIngredients b);
    }
}