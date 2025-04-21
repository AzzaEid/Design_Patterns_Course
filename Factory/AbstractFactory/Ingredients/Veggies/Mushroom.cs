using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class Mushroom : IVeggies
    {
        public override string ToString()
        {
            return "Mushrooms";
        }
    }
}