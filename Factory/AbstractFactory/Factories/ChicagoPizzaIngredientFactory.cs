
using Factory.AbstractFactory.AbstractProducts;
using Factory.AbstractFactory.Ingredients.Cheese;
using Factory.AbstractFactory.Ingredients.Clams;
using Factory.AbstractFactory.Ingredients.Dough;
using Factory.AbstractFactory.Ingredients.Pepperoni;
using Factory.AbstractFactory.Ingredients.Sauce;
using Factory.AbstractFactory.Ingredients.Veggies;

namespace Factory.AbstractFactory.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies =
            {
                new BlackOlives(),
                new Spinach(),
                new Eggplant()
            };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }
    }
}