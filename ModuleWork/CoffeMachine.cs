using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleWork
{
    class CoffeMachine
    {
        public string Name { get; }
        private List<Drink> availableDrinks = new List<Drink>();
        private Dictionary<DateTime, Drink> history = new Dictionary<DateTime, Drink>();
        public readonly Ingredients MaxIngredients;
        private Ingredients CurreentIngredients;

        public CoffeMachine(List<Drink> drinks, string name, int coffe, int milk, int water)
        {
            availableDrinks = drinks;
            Name = name;
            MaxIngredients = new Ingredients(coffe, milk, water);
            CurreentIngredients = new Ingredients(coffe, milk, water);
        }

        public void TakeDrink(string drinkName)
        {
            Drink drink = availableDrinks.FirstOrDefault(x => x.Name == drinkName);
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

        public Dictionary<DateTime, Drink> GetHistory() => history;
    }
}
