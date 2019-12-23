using System;

namespace ModuleWorkModel
{
    public interface IMachineMenu
    {
        IIngredients GetIngredientsUsing(CoffeeMachine machine, DateTime start, DateTime end);
        int CountRefillPeriod(CoffeeMachine machine, DateTime start, DateTime end);
    }
}