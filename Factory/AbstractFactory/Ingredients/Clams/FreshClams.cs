using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Clams
{
    public class FreshClams : IClams
    {
        public override string ToString()
        {
            return "Fresh Clams from Long Island Sound";
        }
    }
}