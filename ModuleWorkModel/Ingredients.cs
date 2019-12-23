using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleWorkModel
{
    public class Ingredients
    {
        private int _coffee;
        private int _milk;
        private int _water;
        public int Coffee
        {
            get => _coffee;
            set
            {
                if (value >= 0) this._coffee = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }
        public int Milk
        {
            get => _milk;
            set
            {
                if (value >= 0) this._milk = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }
        public int Water
        {
            get => _water;
            set
            {
                if (value >= 0) this._water = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }


        public Ingredients(int coffee, int milk, int water)
        {
            Coffee = coffee;
            Milk = milk;
            Water = water;
        }

        public Ingredients() { }

        public static Ingredients operator -(Ingredients a, Ingredients b)
        {
            Ingredients res = new Ingredients();
            res.Coffee = a.Coffee - b.Coffee;
            res.Milk = a.Milk - b.Milk;
            res.Water = a.Water - b.Water;
            return res;

        }

        public static Ingredients operator +(Ingredients a, Ingredients b)
        {
            Ingredients res = new Ingredients();
            res.Coffee = a.Coffee + b.Coffee;
            res.Milk = a.Milk + b.Milk;
            res.Water = a.Water + b.Water;
            return res;

        }
    }
}
