using System;
using System.Collections.Generic;
using System.Text;

namespace ModuleWork
{
    public class Ingredients
    {
        private int _coffe;
        private int _milk;
        private int _water;
        public int Coffe
        {
            get => _coffe;
            set
            {
                if (value >= 0) this._coffe = value;
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


        public Ingredients(int coffe, int milk, int water)
        {
            Coffe = coffe;
            Milk = milk;
            Water = water;
        }

        public Ingredients() { }

        public static Ingredients operator -(Ingredients a, Ingredients b)
        {
            Ingredients res = new Ingredients();
            res.Coffe = a.Coffe - b.Coffe;
            res.Milk = a.Milk - b.Milk;
            res.Water = a.Water - b.Water;
            return res;

        }

        public static Ingredients operator +(Ingredients a, Ingredients b)
        {
            Ingredients res = new Ingredients();
            res.Coffe = a.Coffe + b.Coffe;
            res.Milk = a.Milk + b.Milk;
            res.Water = a.Water + b.Water;
            return res;

        }
    }
}
