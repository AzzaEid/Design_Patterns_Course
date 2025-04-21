namespace Factory.SimpleFactory
{
    public class ClamPizza : Pizza
    {
        #region CONSTRUCTORS

        public ClamPizza() :
            base("Clam Pizza", "Thin crust", "White garlic sauce")
        {
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }

        #endregion
    }
}