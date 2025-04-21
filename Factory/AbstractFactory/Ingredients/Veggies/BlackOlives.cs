using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Veggies
{
    public class BlackOlives : IVeggies
    {
        public override string ToString()
        {
            return "Black Olives";
        }
    }
}