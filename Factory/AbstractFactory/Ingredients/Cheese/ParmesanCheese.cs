using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Cheese
{
    public class ParmesanCheese : ICheese
    {
        public override string ToString()
        {
            return "Shredded Parmesan";
        }
    }
}