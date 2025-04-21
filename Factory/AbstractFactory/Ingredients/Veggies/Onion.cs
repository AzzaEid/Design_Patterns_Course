using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class Onion : IVeggies
    {
        public override string ToString()
        {
            return "Onion";
        }
    }
}