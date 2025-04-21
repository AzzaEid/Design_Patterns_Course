using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Sauce
{
    public class MarinaraSauce : ISauce
    {
        public override string ToString()
        {
            return "Marinara Sauce";
        }
    }
}