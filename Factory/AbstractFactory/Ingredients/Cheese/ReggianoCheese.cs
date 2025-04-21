using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Cheese
{
    public class ReggianoCheese : ICheese
    {
        public override string ToString()
        {
            return "Reggiano Cheese";
        }
    }
}