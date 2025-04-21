namespace Factory.SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        #region CONSTRUCTORS

        public VeggiePizza() :
            base("Veggie Pizza", "Crust", "Marinara sauce")
        {
            Toppings.Add("Shredded mozzarella");
            Toppings.Add("Grated parmesan");
            Toppings.Add("Diced onion");
            Toppings.Add("Sliced mushrooms");
            Toppings.Add("Sliced red pepper");
            Toppings.Add("Sliced black olives");
        }

        #endregion
    }
}