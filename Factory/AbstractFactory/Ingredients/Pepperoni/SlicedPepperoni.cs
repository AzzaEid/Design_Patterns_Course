using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Pepperoni
{
    public class SlicedPepperoni : IPepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}