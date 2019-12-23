using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ModuleWork
{
    class Drink
    {
        public string Name { get;}
        public readonly Ingredients Composition;

        public Drink(string name, int coffe, int milk, int water)
        {
            Name = name;
            Composition = new Ingredients(coffe, milk, water);
        }
    }
}
