using System;
using System.Collections.Generic;
using System.Linq;
using ModuleWorkModel;

namespace ModuleWorkView
{
    public class MachineMenu : IMachineMenu
    {
        public IIngredients GetIngredientsUsing(CoffeeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = new Ingredients();
            foreach (var kvp in machine.GetHistory())
                if (kvp.Key >= start && kvp.Key <= end)
                {
                    var ings = kvp.Value.Composition;
                    usedIngs = usedIngs.Sum(ings) as Ingredients;
                }

            return usedIngs;
        }

        public int CountRefillPeriod(CoffeeMachine machine, DateTime start, DateTime end)
        {
            var usedIngs = GetIngredientsUsing(machine, start, end) as Ingredients;
            var hoursUsing = (end - start).TotalHours;
            var usingSpeeds = new List<double>();
            usingSpeeds.Add(usedIngs.Coffee / hoursUsing);
            usingSpeeds.Add(usedIngs.Milk / hoursUsing);
            usingSpeeds.Add(usedIngs.Water / hoursUsing);
            var refillPeriods = new List<double>();
            refillPeriods.Add((machine.MaxIngredients as Ingredients).Coffee / usingSpeeds[0]);
            refillPeriods.Add((machine.MaxIngredients as Ingredients).Milk / usingSpeeds[1]);
            refillPeriods.Add((machine.MaxIngredients as Ingredients).Water / usingSpeeds[2]);
            var refillPeriod = refillPeriods.Min();
            return (int) refillPeriod;
        }
    }
}