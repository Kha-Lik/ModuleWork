using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleWorkModel
{
    public static class MachineMenu
    {
        public static Ingredients GetIngredientsUsing(CoffeeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = new Ingredients();
            foreach (var kvp in machine.GetHistory())
                if (kvp.Key >= start && kvp.Key <= end)
                    usedIngs += kvp.Value.Composition;

            return usedIngs;
        }

        public static int CountRefillPeriod(CoffeeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = GetIngredientsUsing(machine, start, end);
            var hoursUsing = (end - start).TotalHours;
            var usingSpeeds = new List<double>();
            usingSpeeds.Add(usedIngs.Coffee / hoursUsing);
            usingSpeeds.Add(usedIngs.Milk / hoursUsing);
            usingSpeeds.Add(usedIngs.Water / hoursUsing);
            var refillPeriods = new List<double>();
            refillPeriods.Add(machine.MaxIngredients.Coffee / usingSpeeds[0]);
            refillPeriods.Add(machine.MaxIngredients.Milk / usingSpeeds[1]);
            refillPeriods.Add(machine.MaxIngredients.Water / usingSpeeds[2]);
            var refillPeriod = refillPeriods.Min();
            return (int) refillPeriod;
        }
    }
}