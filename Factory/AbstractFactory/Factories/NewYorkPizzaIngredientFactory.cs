
using Factory.AbstractFactory.AbstractProducts;
using Factory.AbstractFactory.Ingredients.Cheese;
using Factory.AbstractFactory.Ingredients.Clams;
using Factory.AbstractFactory.Ingredients.Dough;
using Factory.AbstractFactory.Ingredients.Pepperoni;
using Factory.AbstractFactory.Ingredients.Sauce;
using Factory.AbstractFactory.Ingredients.Veggies;

namespace Factory.AbstractFactory.Factories
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies =
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }
    }
}