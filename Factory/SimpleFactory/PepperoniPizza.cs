namespace Factory.SimpleFactory
{
    public class PepperoniPizza : Pizza
    {
        #region CONSTRUCTORS

        public PepperoniPizza() :
            base("Pepperoni Pizza", "Crust", "Marinara sauce")
        {
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Sliced Onion");
            Toppings.Add("Grated parmesan cheese");
        }

        #endregion
    }
}