namespace Factory.MethodFactory
{
    public class NYStyleClamPizza : Pizza
    {
        #region CONSTRUCTORS

        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Fresh Clams from Long Island Sound");
        }

        #endregion
    }
}