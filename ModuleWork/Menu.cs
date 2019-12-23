using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleWork
{
    static class Menu
    {
        public static Ingredients GetIngredientsUsing(CoffeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = new Ingredients();
            foreach (var kvp in machine.GetHistory())
            {
                if (kvp.Key >= start && kvp.Key <= end) usedIngs += kvp.Value.Composition;
            }

            return usedIngs;
        }

        public static int CountRefillPeriod(CoffeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = GetIngredientsUsing(machine, start, end);
            var hoursUsing = end.Hour - start.Hour;
            var usingSpeeds = new List<int>();
            usingSpeeds.Add(usedIngs.Coffe / hoursUsing);
            usingSpeeds.Add(usedIngs.Milk / hoursUsing);
            usingSpeeds.Add(usedIngs.Water / hoursUsing);
            var refillPeriods = new List<int>();
            refillPeriods.Add(machine.MaxIngredients.Coffe / usingSpeeds[0]);
            refillPeriods.Add(machine.MaxIngredients.Milk / usingSpeeds[1]);
            refillPeriods.Add(machine.MaxIngredients.Water / usingSpeeds[2]);
            var refillPeriod = refillPeriods.Min();
            return refillPeriod;
        }
    }
}
