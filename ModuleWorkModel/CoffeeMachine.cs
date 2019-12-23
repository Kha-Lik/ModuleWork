using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleWorkModel
{
    public class CoffeeMachine
    {
        private readonly List<Drink> availableDrinks = new List<Drink>();
        private readonly Dictionary<DateTime, Drink> history = new Dictionary<DateTime, Drink>();
        public readonly IIngredients MaxIngredients;
        private IIngredients _curreentIngredients;

        public CoffeeMachine(List<Drink> drinks, string name, IIngredients maxIngredients)
        {
            availableDrinks = drinks;
            Name = name;
            MaxIngredients = maxIngredients;
            _curreentIngredients = maxIngredients;
        }

        public string Name { get; }

        public void TakeDrink(string drinkName)
        {
            var drink = availableDrinks.FirstOrDefault(x => x.Name == drinkName);
            if (drink == null) throw new ArgumentException($"This machine can't make {drinkName}");
            try
            {
                history.Add(DateTime.Now, drink);
                _curreentIngredients = _curreentIngredients.Sub(drink.Composition);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentException($"Not enough ingredients to make {drinkName}");
            }
        }

        public void TakeDrink_dev(string drinkName, DateTime time)
        {
            var drink = availableDrinks.FirstOrDefault(x => x.Name == drinkName);
            if (drink == null) throw new ArgumentException($"This machine can't make {drinkName}");
            try
            {
                history.Add(time, drink);
                _curreentIngredients = _curreentIngredients.Sub(drink.Composition);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentException($"Not enough ingredients to make {drinkName}");
            }
        }

        public Dictionary<DateTime, Drink> GetHistory()
        {
            return history;
        }
    }
}