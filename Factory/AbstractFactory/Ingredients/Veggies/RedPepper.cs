using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class RedPepper : IVeggies
    {
        public override string ToString()
        {
            return "Red Pepper";
        }
    }
}