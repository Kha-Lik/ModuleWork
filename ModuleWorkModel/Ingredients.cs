using System;

namespace ModuleWorkModel
{
    public class Ingredients : IIngredients
    {
        private int _coffee;
        private int _milk;
        private int _water;


        public Ingredients(int coffee, int milk, int water)
        {
            Coffee = coffee;
            Milk = milk;
            Water = water;
        }

        public Ingredients()
        {
        }

        public int Coffee
        {
            get => _coffee;
            set
            {
                if (value >= 0) _coffee = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }

        public int Milk
        {
            get => _milk;
            set
            {
                if (value >= 0) _milk = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }

        public int Water
        {
            get => _water;
            set
            {
                if (value >= 0) _water = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }

        public IIngredients Sub(IIngredients b)
        {
            var sec = b as Ingredients;
            var res = new Ingredients();
            res.Coffee = Coffee - sec.Coffee;
            res.Milk = Milk - sec.Milk;
            res.Water = Water - sec.Water;
            return res;
        }

        public IIngredients Sum(IIngredients b)
        {
            var sec = b as Ingredients;
            var res = new Ingredients();
            res.Coffee = Coffee + sec.Coffee;
            res.Milk = Milk + sec.Milk;
            res.Water = Water + sec.Water;
            return res;
        }
    }
}