using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Dough
{
    public class ThinCrustDough : IDough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}