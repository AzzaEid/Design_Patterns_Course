namespace Factory.MethodFactory
{
    public class NYStyleCheesePizza : Pizza
    {
        #region CONSTRUCTORS

        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }

        #endregion
    }
}