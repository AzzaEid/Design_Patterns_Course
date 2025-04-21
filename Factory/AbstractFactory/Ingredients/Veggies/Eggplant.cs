using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class Eggplant : IVeggies
    {
        public override string ToString()
        {
            return "Eggplant";
        }
    }
}