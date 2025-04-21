using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class Spinach : IVeggies
    {
        public override string ToString()
        {
            return "Spinach";
        }
    }
}