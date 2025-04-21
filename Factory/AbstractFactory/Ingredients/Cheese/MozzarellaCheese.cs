using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Cheese
{
    public class MozzarellaCheese : ICheese
    {
        public override string ToString()
        {
            return "Shredded Mozzarella";
        }
    }
}