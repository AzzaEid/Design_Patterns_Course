using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Dough
{
    public class ThickCrustDough : IDough
    {
        public override string ToString()
        {
            return "ThickCrust style extra thick crust dough";
        }
    }
}