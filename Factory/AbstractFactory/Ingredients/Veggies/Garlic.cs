using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class Garlic : IVeggies
    {
        public override string ToString()
        {
            return "Garlic";
        }
    }
}