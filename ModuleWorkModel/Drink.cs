using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ModuleWorkModel
{
    public class Drink
    {
        public string Name { get;}
        public readonly Ingredients Composition;

        public Drink(string name, int coffee, int milk, int water)
        {
            Name = name;
            Composition = new Ingredients(coffee, milk, water);
        }
    }
}
