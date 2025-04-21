namespace Factory.SimpleFactory
{
    public class CheesePizza : Pizza
    {
        #region CONSTRUCTORS

        public CheesePizza() :
            base("Cheese Pizza", "Regular Crust", "Marinara Pizza Sauce")
        {
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }

        #endregion
    }
}