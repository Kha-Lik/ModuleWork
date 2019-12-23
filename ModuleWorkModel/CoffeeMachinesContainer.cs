using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleWorkModel
{
    public class CoffeeMachinesContainer
    {
        private readonly List<CoffeeMachine> machines = new List<CoffeeMachine>();

        public void AddMachine(List<Drink> drinks, string name, IIngredients maxIngredients)
        {
            if (machines.FirstOrDefault(x => x.Name == name) != null)
                throw new ArgumentException("Already exists machine with this name");
            machines.Add(new CoffeeMachine(drinks, name, maxIngredients));
        }

        public CoffeeMachine GetMachine(string name)
        {
            return machines.Find(x => x.Name == name);
        }

        public List<string> GetMachinesNames()
        {
            return machines.Select(x => x.Name).ToList();
        }
    }
}