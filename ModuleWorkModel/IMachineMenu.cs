using System;

namespace ModuleWorkModel
{
    public interface IMachineMenu
    {
        IIngredients GetIngredientsUsing(DateTime start, DateTime end);
        int CountRefillPeriod(DateTime start, DateTime end);
    }
}