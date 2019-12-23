using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleWorkModel
{
    public class MachineMenu : IMachineMenu
    {
        private CoffeeMachine _machine;

        public MachineMenu(CoffeeMachine machine) => _machine = machine;
        public IIngredients GetIngredientsUsing( DateTime start, DateTime end)
        {
            var usedIngs = new Ingredients();
            foreach (var kvp in _machine.GetHistory())
                if (kvp.Key >= start && kvp.Key <= end)
                {
                    var ings = kvp.Value.Composition;
                    usedIngs = usedIngs.Sum(ings) as Ingredients;
                }

            return usedIngs;
        }

        public int CountRefillPeriod( DateTime start, DateTime end)
        {
            var usedIngs = GetIngredientsUsing(start, end) as Ingredients;
            var hoursUsing = (end - start).TotalHours;
            var usingSpeeds = new List<double>();
            usingSpeeds.Add(usedIngs.Coffee / hoursUsing);
            usingSpeeds.Add(usedIngs.Milk / hoursUsing);
            usingSpeeds.Add(usedIngs.Water / hoursUsing);
            var refillPeriods = new List<double>();
            refillPeriods.Add((_machine.MaxIngredients as Ingredients).Coffee / usingSpeeds[0]);
            refillPeriods.Add((_machine.MaxIngredients as Ingredients).Milk / usingSpeeds[1]);
            refillPeriods.Add((_machine.MaxIngredients as Ingredients).Water / usingSpeeds[2]);
            var refillPeriod = refillPeriods.Min();
            return (int) refillPeriod;
        }
    }
}