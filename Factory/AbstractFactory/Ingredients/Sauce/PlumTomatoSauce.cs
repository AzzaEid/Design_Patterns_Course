using Factory.AbstractFactory.AbstractProducts;

namespace Factory.AbstractFactory.Ingredients.Sauce
{
    public class PlumTomatoSauce : ISauce
    {
        public override string ToString()
        {
            return "Tomato sauce with plum tomatoes";
        }
    }
}