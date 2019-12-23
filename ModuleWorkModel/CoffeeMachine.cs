using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleWorkModel
{
    public class CoffeeMachine
    {
        public readonly Ingredients MaxIngredients;
        private readonly List<Drink> availableDrinks = new List<Drink>();
        private Ingredients CurreentIngredients;
        private readonly Dictionary<DateTime, Drink> history = new Dictionary<DateTime, Drink>();

        public CoffeeMachine(List<Drink> drinks, string name, int coffe, int milk, int water)
        {
            availableDrinks = drinks;
            Name = name;
            MaxIngredients = new Ingredients(coffe, milk, water);
            CurreentIngredients = new Ingredients(coffe, milk, water);
        }

        public string Name { get; }

        public void TakeDrink(string drinkName)
        {
            var drink = availableDrinks.FirstOrDefault(x => x.Name == drinkName);
            if (drink == null) throw new ArgumentException($"This machine can't make {drinkName}");
            try
            {
                history.Add(DateTime.Now, drink);
                CurreentIngredients -= drink.Composition;
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
                CurreentIngredients -= drink.Composition;
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