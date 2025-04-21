namespace Factory.MethodFactory
{
    using System;

    public class ChicagoStyleClamPizza : Pizza
    {
        #region CONSTRUCTORS

        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        #endregion

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}