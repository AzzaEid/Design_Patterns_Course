using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Clams
{
    public class FrozenClams : IClams
    {
        public override string ToString()
        {
            return "Frozen Clams from Chesapeake Bay";
        }
    }
}